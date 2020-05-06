import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';

import { Observable } from 'rxjs';
import { Contact } from './contact';


@Injectable({
  providedIn: 'root'
})
export class ContactService {
  url = 'http://localhost/CIB.PhoneBook.Services.WebApi/Api/Contact';
  constructor(private http: HttpClient) { }

  getAll(): Observable<Contact[]> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json', 'Access-Control-Allow-Origin': '*' }) };
    return this.http.get<Contact[]>(this.url + '/GetAll', httpOptions);
  }

  getById(id: number): Observable<Contact> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json', 'Access-Control-Allow-Origin': '*' }) };
    return this.http.get<Contact>(this.url + '/GetById/' + id, httpOptions);
  }
  create(contact: Contact): Observable<Contact> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json', 'Access-Control-Allow-Origin': '*' }) };
    return this.http.post<Contact>(this.url + '/Insert/', contact, httpOptions);
  }

  update(contact: Contact): Observable<Contact> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json', 'Access-Control-Allow-Origin': '*' }) };
    return this.http.put<Contact>(this.url + '/Update/', contact, httpOptions);
  }

  deleteById(id: number): Observable<number> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json', 'Access-Control-Allow-Origin': '*' })};
    return this.http.delete<number>(this.url + '/Delete?id=' + id, httpOptions);
  }

}
