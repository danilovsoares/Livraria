import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";

import { LivroService } from "../livro.services";
import { LivroModel } from "../models/livro.model";
import { SwalService } from "../../utils/swal/swal.service";

declare interface TableData {
  headerRow: string[];
  dataRows: Array<LivroModel>;
}

@Component({
  selector: "app-livro-listar",
  templateUrl: "./livro-listar.component.html",
  styleUrls: ["./livro-listar.component.css"]
})
export class LivroListarComponent implements OnInit {
  public tableData: TableData;

  constructor(
    public livroService: LivroService,
    private router: Router,
    public swalService: SwalService
  ) {}

  ngOnInit() {
    this.obterLivros();
  }

  private obterLivros() {
    this.livroService.obterLivros().subscribe(livros => {
      this.montarDataRowGrid(livros);
    });
  }

  private montarDataRowGrid(livros) {
    this.tableData = {
      headerRow: this.montarHeaderRow(),
      dataRows: livros
    };
  }

  private montarHeaderRow(): Array<string> {
    return [
      "Título",
      "Descrição",
      "Autor",
      "Editora",
      "Número da edição",
      "Ano da edição",
      "ISBN",
      "Ação"
    ];
  }

  public editar(id) {
    this.router.navigate(["/livro/editar", id]);
  }

  public remover(id) {
    if (!id) {
      return;
    }

    this.swalService.confirmar().then(result => {
      if (result.value) {
        this.livroService.excluir(id).subscribe(res => {
          this.obterLivros();
          this.swalService.sucesso("Excluído com sucesso!");
        });
      }
    });
  }
}
