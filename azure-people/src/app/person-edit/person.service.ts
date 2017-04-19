import { Injectable } from '@angular/core';
import {Http, Response, Headers, RequestOptions} from '@angular/http';
import {Observable} from 'rxjs/Observable';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/finally';
import 'rxjs/add/operator/map';

import {ENDPOINT} from '../core/config';
import {Person, PersonType} from '../shared/models/person';

@Injectable()
export class PersonService {

  constructor(
    private http:Http,
  ) { }

  deletePerson(personId:string):Observable<boolean>{
    let body = JSON.stringify(personId);
    let options = new RequestOptions({ headers: new Headers({ 'Content-Type': 'application/json' }) })
    return <Observable<boolean>> this.http
    .post(`${ENDPOINT}person/deleteperson/`, body, options)
    .map(res=>res.json() as boolean)
  }

  getPerson(personId:string):Observable<Person>{
    return <Observable<Person>> this.http
    .get(`${ENDPOINT}person/person/` + personId)
    .map(res=>res.json() as Person)
  }

  getPersonTypeList():Observable<PersonType[]>{
    return <Observable<PersonType[]>> this.http
    .get(`${ENDPOINT}person/persontype/`)
    .map(res=>res.json() as PersonType[])
  }

  savePerson(person:Person):Observable<string>{
    let body = JSON.stringify(person);
    let options = new RequestOptions({ headers: new Headers({ 'Content-Type': 'application/json' }) })
    return <Observable<string>> this.http
    .post(`${ENDPOINT}person/saveperson/`, body, options)
    .map(res=>res.json() )
  }
}
