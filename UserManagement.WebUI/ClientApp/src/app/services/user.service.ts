import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';
import { User } from '../models/User';
import { UserListQuery } from '../models/UserListQuery';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private url = "https://localhost:44314/api/";
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  constructor(private httpClient: HttpClient) { }

  getUsers(queryModel: UserListQuery): Observable<any> {
    return this.httpClient.post<any>(this.url + "user/list", queryModel, this.httpOptions)
      .pipe(
        catchError(this.httpErrorHandler)
      );
  }

  assignUser(user: any): Observable<any> {
    return this.httpClient.post<any>(this.url + "user/assign", user, this.httpOptions)
      .pipe(
        catchError(this.httpErrorHandler)
      );
  }

  editUser(user: any): Observable<any> {
    return this.httpClient.patch<User[]>(this.url + "user/update/" + user.id, user, this.httpOptions)
      .pipe(
        catchError(this.httpErrorHandler)
      );
  }

  addUser(user: any): Observable<number> {
    return this.httpClient.post<number>(this.url + "user/create", user, this.httpOptions)
      .pipe(
        catchError(this.httpErrorHandler)
      );
  }

  getUser(id: number): Observable<User> {
    return this.httpClient.get<User>(this.url + "user/details/" + id)
      .pipe(
        catchError(this.httpErrorHandler)
      );
  }

  deleteUser(id: number): Observable<any> {
    return this.httpClient.delete<any>(this.url + "user/delete/" + id)
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
