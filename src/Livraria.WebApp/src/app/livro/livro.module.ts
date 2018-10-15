import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { LivroCadastrarComponent } from './livro-cadastrar/livro-cadastrar.component';
import { NgModule } from '@angular/core';
import { LivroListarComponent } from './livro-listar/livro-listar.component';
import { LivroEditarComponent } from './livro-editar/livro-editar.component';
import { LivroService } from './livro.services';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule
  ],
  declarations: [
    LivroCadastrarComponent,
    LivroListarComponent,
    LivroEditarComponent
  ],
  providers: [
    LivroService
  ],
  exports: [],
})
export class LivroModule {}
