
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { UserListComponent } from './compotnents/user-list/user-list.component';
import { UserDetailComponent } from './compotnents/user-detail/user-detail.component';
import { UserAddComponent } from './compotnents/user-add/user-add.component';
import { UserEditComponent } from './compotnents/user-edit/user-edit.component';
import { NavMenuComponent } from './compotnents/nav-menu/nav-menu.component';
import { UserAssignComponent } from './compotnents/user-assign/user-assign.component';
import { UserPermissionListComponent } from './compotnents/user-permission-list/user-permission-list.component';
import { PaginationComponent } from './compotnents/pagination/pagination.component';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    UserListComponent,
    UserDetailComponent,
    UserAddComponent,
    UserEditComponent,
    UserAssignComponent,
    UserPermissionListComponent,
    PaginationComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', redirectTo: 'user-list', pathMatch: 'full' },
      { path: 'user-list', component: UserListComponent },
      { path: 'user-add', component: UserAddComponent },
      { path: 'user-details/:id', component: UserDetailComponent },
      { path: 'user-assign/:id', component: UserAssignComponent },
      { path: 'user-edit/:id', component: UserEditComponent }
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
