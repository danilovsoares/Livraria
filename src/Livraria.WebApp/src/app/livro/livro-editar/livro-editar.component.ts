import { Component, OnInit } from "@angular/core";
import { Router, ActivatedRoute } from "@angular/router";

import { LivroService } from "./../livro.services";
import { LivroModel } from "../models/livro.model";
import { SwalService } from "../../utils/swal/swal.service";
import { LivroEditarValidation } from "./livro-editar.validation";
import { FormGroup } from "@angular/forms";

@Component({
  selector: "app-livro-editar",
  templateUrl: "./livro-editar.component.html",
  styleUrls: ["./livro-editar.component.css"],
  providers: [LivroModel, LivroEditarValidation]
})
export class LivroEditarComponent implements OnInit {
  public myform: FormGroup;

  constructor(
    private router: Router,
    private route: ActivatedRoute,
    public model: LivroModel,
    public livroService: LivroService,
    public swalService: SwalService,
    public livroEditarValidation: LivroEditarValidation
  ) {}

  ngOnInit() {
    this.route.params.subscribe((params: any) => {
      const id = params["id"];
      if (!id) {
        this.cancelar();
        return;
      }

      this.myform = this.livroEditarValidation.formControl(
        this.model
      );

      this.livroService.obterLivroPorId(id).subscribe(
        res => {
          this.model = res;

          if (!this.model) {
            this.livroNaoEncontrado();
          }
        },
        error => {
          this.livroNaoEncontrado();
        }
      );
    });
  }

  onSubmit() {

    if (this.myform.invalid) {
      this.swalService.atencao("Preencha todos os campos obrigatórios.");
      return null;
    }

    this.livroService.atualizar(this.model).subscribe(res => {
      this.swalService.sucesso("Salvo com sucesso!").then(result => {
        this.cancelar();
      });
    });
  }

  livroNaoEncontrado() {
    this.swalService.atencao("Livro não foi encontrado!").then(result => {
      this.cancelar();
    });
  }

  cancelar() {
    this.router.navigate(["/livro/listar"]);
  }
}
