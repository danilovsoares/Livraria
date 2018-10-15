import { Injectable } from "@angular/core";

import swal from "sweetalert2/dist/sweetalert2.js";

@Injectable()
export class SwalService {
  public sucesso(texto: string) {
    return swal({
      type: "success",
      title: texto,
      showConfirmButton: false,
      timer: 2000
    });
  }

  public atencao(texto: string) {
    return swal({
      type: "error",
      title: "Atenção",
      text: texto,
      confirmButtonColor: "#777777",
      confirmButtonText: "OK"
    });
  }

  public confirmar() {
    return swal({
      title: "Excluir?",
      text: "Deseja realmente excluir?",
      type: "warning",
      showCancelButton: true,
      confirmButtonColor: "#EE2D20",
      cancelButtonColor: "#777777",
      confirmButtonText: "Sim"
    });
  }

  public erro(er: any) {
    let html = '';

    for (let index = 0; index < er.error.errors.length; index++) {
      const element = er.error.errors[index];

      html = `${html}<br />${element}`;
    }

    swal({
      type: 'error',
      title: 'Ocorreu um erro',
      html: html,
      confirmButtonColor: '#777777',
      confirmButtonText: 'OK'
    });
  }
}
