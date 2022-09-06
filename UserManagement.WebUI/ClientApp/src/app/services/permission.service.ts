import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Permission } from '../models/Permission';
import { UserPermissionListQuery } from '../models/UserPermissionListQuery';

@Injectable({
  providedIn: 'root'
})
export class PermissionService {
  private url = "https://localhost:44314/api/";
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };
  constructor(private httpClient: HttpClient) { }

  getPermissions(queryModel: UserPermissionListQuery): Observable<any> {
    return this.httpClient.post<any>(this.url + "permission/list", queryModel, this.httpOptions)
      .pipe(
        catchError(this.httpErrorHandler)
      );
  }

  private httpErrorHandler(error: HttpErrorResponse) {
    if (error.error instanceof ErrorEvent) {
      console.error("A client side error occurs. The error message is " + error.message);
    } else {
      console.error(
        "An error happened in server. The HTTP status code is " + error.status + " and the error returned is " + error.message);
    }

    return throwError("Error occurred. Pleas try again");
  }
}
