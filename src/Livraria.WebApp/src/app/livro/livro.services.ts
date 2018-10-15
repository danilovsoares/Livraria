import { Injectable } from "@angular/core";
import { ApiService } from "../services/api.service";
import { Observable } from "rxjs";
import { map } from "rxjs/operators";
import { environment } from "../../environments/environment";
import { LivroModel } from "./models/livro.model";

@Injectable()
export class LivroService {
  constructor(public apiService: ApiService) {}

  salvar(livro: LivroModel): Observable<LivroModel> {

    return this.apiService.post(`${this.obterUrlEndpoint()}/novo`, livro)
    .pipe(
      map((res: any) => {
        return <LivroModel>res.data;
      })
    );
  }

  atualizar(livro: LivroModel): Observable<LivroModel> {

    return this.apiService.put(`${this.obterUrlEndpoint()}/atualizar`, livro)
    .pipe(
      map((res: any) => {
        return <LivroModel>res.data;
      })
    );
  }

  obterLivros(): Observable<LivroModel> {
    return this.apiService.get(this.obterUrlEndpoint())
    .pipe(
      map((res: any) => {
        return <LivroModel>res.data;
      })
    );
  }

  obterLivroPorId(id: any): Observable<LivroModel> {
    return this.apiService.get(`${this.obterUrlEndpoint()}/${id}`)
    .pipe(
      map((res: any) => {
        return <LivroModel>res.data;
      })
    );
  }

  excluir(id: string): Observable<LivroModel> {
    return this.apiService.delete(`${this.obterUrlEndpoint()}/deletar/${id}`)
    .pipe(
      map((res: any) => {
        return <LivroModel>res.data;
      })
    );
  }

  obterUrlEndpoint(): string {

    return `${environment.EndpointWebAPI}livro`;
  }
}
