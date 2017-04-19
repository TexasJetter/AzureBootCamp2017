import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PeopleListComponent } from './people-list/people-list.component';
import {PersonEditComponent} from './person-edit/person-edit.component';

const routes: Routes = [
  { path: '', pathMatch: 'full', redirectTo: 'people', },
  { path: 'people', component: PeopleListComponent },
  { path: 'person/:id', component: PersonEditComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
