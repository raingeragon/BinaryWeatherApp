import { Injectable } from '@angular/core';
import { Http } from '@angular/http';

import 'rxjs/add/operator/map';

import { City } from "../models/city";

import { Observable } from "rxjs/Observable";

@Injectable()
export class CitiesService
{
    cities: City[];
    apipath:string;
    http: Http;
  constructor(http: Http) {
    this.apipath = "http://localhost:59524/api/";
  }
  get Cities(): Observable<City[]>
  {
      return this.http.get(this.apipath+'Towns').map(res => res.json());
  }
  deleteCity(name: string)
  {
      return this.http.delete(this.apipath+'Towns/?name='+name);
  }
  addCity(name: string)
  {
      return this.http.post(this.apipath+'Towns/?name='+name,{'Name':name});
  }

}