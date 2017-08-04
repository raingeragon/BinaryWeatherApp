import { Injectable } from '@angular/core';

import { Http } from "@angular/http";
import { HistoryElem } from "../models/historyElem";

import { Observable } from "rxjs/Observable";

@Injectable()
export class HistoryService
{
    apipath:string;
    http: Http;
    constructor(http: Http)
    {
        this.apipath = "http://localhost:59524/api/";
    }

  getHistory(): Observable<HistoryElem[]> {
    return this.http.get(this.apipath+'Requests').map(res=>res.json());
  }
}
