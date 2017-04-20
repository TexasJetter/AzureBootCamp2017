import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { PeopleListItem } from '../shared/models/people';
import { PeopleListService } from './people-list.service';
import { PersonService } from '../person-edit/person.service';

@Component({
  selector: 'ap-people-list',
  templateUrl: './people-list.component.html',
  styleUrls: ['./people-list.component.css']
})
export class PeopleListComponent implements OnInit {

  constructor(
    private peopleListService: PeopleListService,
    private personService: PersonService,
    private router: Router
  ) { }

  personList: PeopleListItem[] = [];
  errorMessage:string="";
  loading:boolean= true;
  addPerson():void{
    this.router.navigate(['/person', "00000000-0000-0000-0000-000000000000"]);
  }

  deletePerson(personId:string):void{
    this.errorMessage = "";
    this.loading = true;
    this.personService.deletePerson(personId)
    .subscribe(success=>{
      if(success){
        let index = this.personList.findIndex(function(item){return item.id == personId});
        this.personList.splice(index,1);
      }else{
        this.errorMessage = "There was a problem deleting";
      }
      this.loading = false;
    })
  }

  editPerson(personId:string):void{
    this.router.navigate(['/person', personId]);
  }

  ngOnInit() {
    this.peopleListService.getPeopleList()
    .subscribe(people=>{
      this.personList = people;
      this.loading = false;
    })
  }

}
