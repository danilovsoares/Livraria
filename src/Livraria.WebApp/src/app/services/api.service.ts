import { throwError as observableThrowError,  Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { catchError } from 'rxjs/operators';
import { SwalService } from '../utils/swal/swal.service';

@Injectable()
export class ApiService {
  constructor(private http: HttpClient, public swalService: SwalService) {}

  post(url: string, data: any): Observable<any> {
    return this.http.post(url, data).pipe(
      catchError(error => {
        this.swalService.erro(error);
        return observableThrowError(error);
      }));
  }

  put(url: string, data: any): Observable<any> {
    return this.http.put(url, data).pipe(
      catchError(error => {
        this.swalService.erro(error);
        return observableThrowError(error);
      }));
  }

  delete(url: string): Observable<any> {
    return this.http.delete(url).pipe(
      catchError(error => {
        this.swalService.erro(error);
        return observableThrowError(error);
      }));
  }
  get(url: string): Observable<any> {
    return this.http.get(url).pipe(
      catchError(error => {
        this.swalService.erro(error);
        return observableThrowError(error);
      }));
  }
}
