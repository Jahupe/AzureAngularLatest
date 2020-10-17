import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecasts: WeatherForecast[];

  public Products: Product[];
  //private ProductURL = "https://localhost:44300/api/Product"; //Entorno Local
  private ProductURL =  "https://azuredevopsangularapi1610.azurewebsites.net/api/Product"; //Entorno Azure


  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    //http.get<WeatherForecast[]>(baseUrl + 'weatherforecast').subscribe(result => {
    //  this.forecasts = result;
    //}, error => console.error(error));
    http.get<Product[]>(this.ProductURL).subscribe(result => {
      this.Products = result;
    }, error => console.error(error));
  }
}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}

interface Product {
  ProductId: number;
  Description: string;
  Price: number;
  Created: Date;
  Updated: Date;
}
