import { Injectable } from '@angular/core';
import {TerritorioDetails} from './territorio-details.model'
import {HttpClient} from '@angular/common/http'
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TerritorioDetailsService {

  constructor(private http:HttpClient) { }

  readonly baseURL='https://localhost:44368/api/Territories'

  formData:TerritorioDetails = new TerritorioDetails();
  list: TerritorioDetails[];

  postTerritorio()
  {
    return this.http.post(this.baseURL,this.formData );
  }

  putTerritorio()
  {
    return this.http.put(`${this.baseURL}/${this.formData.TerritoryID}`,this.formData );
  } 


  refreshList()
  {
    this.http.get(this.baseURL).toPromise().then(res=> this.list =res as TerritorioDetails[] )
  }
 

  delete(id:string)
  {
    return this.http.delete(`${this.baseURL}/${id}` );
  }
}
