import { Routes, RouterModule } from "@angular/router";
import { NgModule } from "@angular/core";
import { LivroListarComponent } from "../livro/livro-listar/livro-listar.component";
import { LivroCadastrarComponent } from "../livro/livro-cadastrar/livro-cadastrar.component";
import { LivroEditarComponent } from "../livro/livro-editar/livro-editar.component";
import { AdminLayoutComponent } from "../layouts/admin-layout/admin-layout.component";

const routes: Routes = [
  {
    path: "",
    redirectTo: "livro/listar",
    pathMatch: "full"
  },
  {
    path: "",
    component: AdminLayoutComponent,
    children: [
      {
        path: "livro",
        children: [
          {
            path: "listar",
            component: LivroListarComponent
          },
          {
            path: "cadastrar",
            component: LivroCadastrarComponent
          },
          {
            path: "editar/:id",
            component: LivroEditarComponent
          }
        ]
      }
    ]
  },
  {
    path: "**",
    redirectTo: "livro/listar",
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
