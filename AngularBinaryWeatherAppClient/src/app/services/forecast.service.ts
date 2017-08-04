import { Injectable } from '@angular/core';
import { Http } from "@angular/http";
import { Observable } from "rxjs/Observable";

import { Forecast } from "../models/forecast";

@Injectable()
export class WeatherService 
{
    apipath:string;
    http: Http;
    constructor(http: Http) {
        this.apipath = "http://localhost:59524/api/";
  }

  getWeather(city: string, days: string): Observable<Forecast>{
      return this.http.get(this.apipath+'Weather/?city='+city+'&days='+days).map(res => res.json());
  }
}
