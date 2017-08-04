import { Component, OnInit } from '@angular/core';
import {HistoryElem} from '../models/historyElem'
@Component({
  selector: 'app-history',
  templateUrl: './history.component.html',
  styleUrls: ['./history.component.css']
})
export class HistoryComponent implements OnInit {
  private historyList: HistoryElem[];
  constructor() { }

  ngOnInit() {
    
  }

}
