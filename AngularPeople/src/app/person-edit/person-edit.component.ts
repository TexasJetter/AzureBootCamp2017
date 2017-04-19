import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Location } from '@angular/common';

import { Person, PersonType } from '../shared/models/person';
import { PersonService } from './person.service';

@Component({
  selector: 'ap-person-edit',
  templateUrl: './person-edit.component.html',
  styleUrls: ['./person-edit.component.css']
})
export class PersonEditComponent implements OnInit {

  constructor(
    private personService: PersonService,
    route: ActivatedRoute,
    private location: Location,
    private router: Router,
  ) {
    this.personId = route.snapshot.params['id'];
  }
  emptyGuid:string = "00000000-0000-0000-0000-000000000000";
  personId: string;
  person: Person = new Person(this.emptyGuid,"","","","",this.emptyGuid);
  personTypes:PersonType[]=[];

  back(): void {
    this.location.back();
  }

  save():void{
    this.personService.savePerson(this.person)
    .subscribe(personId=>{
      this.person.id=personId
      this.back();
    })
  }

  ngOnInit() {
    this.personService.getPersonTypeList()
    .subscribe(t=> {this.personTypes = t});
    if (this.personId != this.emptyGuid) {
      this.personService.getPerson(this.personId)
        .subscribe(person => {
          this.person = person
        });
    }
  }

}
