import { Component, OnInit } from '@angular/core';
import { TerritorioDetails } from '../shared/territorio-details.model';
import {TerritorioDetailsService} from '../shared/territorio-details.service';

@Component({
  selector: 'app-territorio-details',
  templateUrl: './territorio-details.component.html',
  styles: [
  ]
})
export class TerritorioDetailsComponent implements OnInit {

  constructor(public service: TerritorioDetailsService) { }

  ngOnInit(): void {
    this.service.refreshList();
  }

  populateForm(selectedRecord:TerritorioDetails)
  {
    this.service.formData= Object.assign({}, selectedRecord);

  }

  Delete(id:string)
  {
    if (confirm('¿Esta seguro de borrar el registro?'))
    {
      this.service.delete(id).subscribe(
        res=>{
          this.service.refreshList();
        },
        error=>{
          console.log(error)
        }
      )
      
    }
    
  }

}
