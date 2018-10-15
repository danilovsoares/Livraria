import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { FormGroup } from "@angular/forms";

import { LivroModel } from "../models/livro.model";
import { LivroService } from "../livro.services";
import { SwalService } from "../../utils/swal/swal.service";
import { LivroCadastrarValidation } from "./livro-cadastrar.validation";

@Component({
  selector: "app-livro-cadastrar",
  templateUrl: "./livro-cadastrar.component.html",
  styleUrls: ["./livro-cadastrar.component.css"],
  providers: [LivroModel, LivroCadastrarValidation]
})
export class LivroCadastrarComponent implements OnInit {
  public myform: FormGroup;

  constructor(
    private router: Router,
    public model: LivroModel,
    public livroService: LivroService,
    public swalService: SwalService,
    public livroCadastrarValidation: LivroCadastrarValidation
  ) {}

  ngOnInit() {
    this.myform = this.livroCadastrarValidation.formControl(
      this.model
    );
  }

  onSubmit() {

    if (this.myform.invalid) {
      this.swalService.atencao("Preencha todos os campos obrigatórios.");
      return null;
    }

    this.livroService.salvar(this.model).subscribe(res => {

      this.swalService.sucesso("Salvo com sucesso!")
      .then(result => {
        this.model = new LivroModel();
      });
    });
  }

  cancelar() {
    this.router.navigate(['/livro/listar']);
  }
}
