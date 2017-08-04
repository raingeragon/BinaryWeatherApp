import { Component, OnInit } from '@angular/core';
import {historyElem} from '../models/historyElem'
@Component({
  selector: 'app-history',
  templateUrl: './history.component.html',
  styleUrls: ['./history.component.css']
})
export class HistoryComponent implements OnInit {
  private historyList: historyElem[];
  constructor() { }

  ngOnInit() {
    
  }

}
