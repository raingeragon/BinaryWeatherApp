import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { HttpModule } from "@angular/http";
import { AppRoutingModule } from './app-routing.module';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { WeatherComponent } from './weather/weather.component';
import { HistoryComponent } from './history/history.component';
import { CitiesComponent } from './cities/cities.component';

import {WeatherService} from './services/forecast.service';
import {CitiesService} from './services/cities.service';
import {HistoryService} from './services/history.service';

@NgModule({
  declarations: [
    AppComponent,
    WeatherComponent,
    HistoryComponent,
    CitiesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpModule,
    FormsModule
  ],
  providers: [
    WeatherService,
    HistoryService,
    CitiesService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
