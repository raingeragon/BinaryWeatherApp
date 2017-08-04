import { Component, OnInit } from '@angular/core';
import { Observable } from "rxjs/Observable";
import { Router } from '@angular/router';

import {Forecast} from "../models/forecast";
import {City} from "../models/city";

import {WeatherService} from "../services/forecast.service"
import {CitiesService} from "../services/cities.service"

@Component({
  selector: 'app-weather',
  templateUrl: './weather.component.html',
  styleUrls: ['./weather.component.css']
})
export class WeatherComponent implements OnInit 
{
  
  constructor() { }
  city:string;
  days:number;
  ngOnInit() {
  }

}
