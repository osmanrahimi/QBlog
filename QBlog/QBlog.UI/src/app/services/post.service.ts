
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import {  Response, Headers, RequestOptions } from '@angular/http';

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';
import 'rxjs/add/operator/map';
import 'rxjs/add/observable/of';
import { IPost } from '../models/ipost';


@Injectable()
export class PostService {

  constructor(private http: HttpClient) { }

  //
  getProducts(): Observable<IPost[]> {
    console.log('in service')
    return this.http.get("http://localhost:11597/api/Post/Get/0")
      .map(this.extractData)
      .do(data => console.log('getProducts: ' + JSON.stringify(data)))
      .catch(this.handleError);
  }


  private extractData(response: Response) {
    console.log('in extract');
    let body = response.json();
    return body.data || {};
  }

  private handleError(error: Response): Observable<any> {
    console.log('in handel error');
    console.error(error);
    return Observable.throw(error.json().error || 'Server error');
  }
}
