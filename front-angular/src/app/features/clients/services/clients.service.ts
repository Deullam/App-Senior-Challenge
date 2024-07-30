import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { first, Observable, tap } from 'rxjs';
import { Client } from '../models/client';

@Injectable({
  providedIn: 'root'
})
export class ClientsService {

  private readonly apiUrl = '../../../assets/clients.json';

  constructor(private http: HttpClient) { }

  addClient(client: any): Observable<any> {
    return this.http.post(this.apiUrl, client);
  }

  updateClient(client: any): Observable<any> {
    return this.http.put(`${this.apiUrl}/${client.id}`, client);
  }

  deleteClient(id: number): Observable<any> {
    return this.http.delete(`${this.apiUrl}/${id}`);
  }

  getClients() {
    return this.http.get<Client[]>(this.apiUrl)
      .pipe(
        tap(clients => console.log(clients)));
  }

}
