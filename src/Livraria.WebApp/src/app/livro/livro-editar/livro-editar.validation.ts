import { Injectable } from '@angular/core';
import { LivroModel } from '../models/livro.model';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Injectable()
export class LivroEditarValidation {
  public formControl(model: LivroModel): FormGroup {
    return new FormGroup({
      titulo: new FormControl(model.titulo, [
        Validators.required,
        Validators.maxLength(50)
      ]),
      descricao: new FormControl(model.descricao, [
        Validators.required,
        Validators.maxLength(255)
      ]),
      autor: new FormControl(model.autor, [
        Validators.required,
        Validators.maxLength(50)
      ]),
      editora: new FormControl(model.editora, [
        Validators.required,
        Validators.maxLength(50)
      ]),
      numeroEdicao: new FormControl(model.numeroEdicao, [
        Validators.required,
        Validators.maxLength(7)
      ]),
      anoEdicao: new FormControl(model.anoEdicao, [
        Validators.required,
        Validators.maxLength(4)
      ]),
      isbn: new FormControl(model.isbn, [
        Validators.required,
        Validators.maxLength(50)
      ])
    });
  }
}
