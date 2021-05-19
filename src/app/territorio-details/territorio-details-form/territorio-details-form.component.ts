import { Component, OnInit } from '@angular/core';
import { TerritorioDetailsService } from 'src/app/shared/territorio-details.service';
import { AbstractControl, FormGroup, NgForm } from '@angular/forms';
import { TerritorioDetails } from 'src/app/shared/territorio-details.model';

@Component({
  selector: 'app-territorio-details-form',
  templateUrl: './territorio-details-form.component.html',
  styles: [
  ]
})
export class TerritorioDetailsFormComponent implements OnInit {
  isChecked = false;

  

 

  constructor(public service: TerritorioDetailsService) { }

  ngOnInit(): void {
  }




  onSubmit(form: NgForm) {
    

    if (this.service.formData.TerritoryID=='0') {
      this.insertRecord(form);
    }
    else
      this.updateRecord(form)
  }
  insertRecord(form: NgForm) {
    this.service.postTerritorio().subscribe
      (
        res => {
          this.resetForm(form);
          this.service.refreshList();


        },
        error => { console.log(error); }

      );

  }
  updateRecord(form: NgForm) {
    this.service.putTerritorio().subscribe
      (
        res => {
          this.resetForm(form);
          this.service.refreshList();


        },
        error => { console.log(error); }

      );

  }

  resetForm(form: NgForm) {
    form.form.reset();
    this.service.formData = new TerritorioDetails();
  }

  

  



}

