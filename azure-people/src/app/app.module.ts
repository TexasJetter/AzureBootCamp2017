import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PeopleListComponent } from './people-list/people-list.component';
import { PeopleListService } from './people-list/people-list.service';
import { PersonEditComponent } from './person-edit/person-edit.component';
import { PersonService } from './person-edit/person.service';

@NgModule({
  declarations: [
    AppComponent,
    PeopleListComponent,
    PersonEditComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    AppRoutingModule
  ],
  providers: [PeopleListService, PersonService],
  bootstrap: [AppComponent]
})
export class AppModule { }
