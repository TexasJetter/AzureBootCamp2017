import { Injectable } from '@angular/core';
import {Http, Response} from '@angular/http';
import {Observable} from 'rxjs/Observable';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/finally';
import 'rxjs/add/operator/map';

import {ENDPOINT} from '../core/config';
import {PeopleListItem} from '../shared/models/people';

@Injectable()
export class PeopleListService {

  constructor(
    private http:Http,

  ) { }

  getPeopleList():Observable<PeopleListItem[]>{
    return <Observable<PeopleListItem[]>> this.http
    .get(`${ENDPOINT}person/`)
    .map(res=>res.json() as PeopleListItem[] )
  }
}
