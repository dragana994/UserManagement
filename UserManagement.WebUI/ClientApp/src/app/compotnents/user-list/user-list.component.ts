import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { User } from 'src/app/models/User';
import { UserListQuery } from 'src/app/models/UserListQuery';
import { UserService } from 'src/app/services/user.service';
import { UserDeleteModalComponent } from '../user-delete-modal/user-delete-modal.component';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.css']
})
export class UserListComponent implements OnInit {
  users: User[];

  currentPage: number = 1;
  totalPages: number;

  searchQuery: string = "";
  sortByColumn = "id";
  sortAscending = true;

  constructor(private userService: UserService, private router: Router, private _modalService: NgbModal) { }

  ngOnInit() {
    this.getUsers();
  }

  addUser() {
    this.router.navigate(['/user-add']);
  }

  deleteUser(event: any, user:User) {
    event.preventDefault();

    let modalRef = this._modalService.open(UserDeleteModalComponent);
    modalRef.componentInstance.user = user;

    modalRef.result.then(result => {
      if (result.toUpperCase() === "OK") {
        this.userService.deleteUser(user.id)
          .subscribe(_ => this.getUsers());
      }
    });
  }

  getUsers() {
    let query: UserListQuery = {
      searchQuery: this.searchQuery,
      pageSize: 10,
      page: this.currentPage,
      sortColumnName: this.sortByColumn,
      sortAscending: this.sortAscending
    };

    this.userService.getUsers(query).subscribe(res => {
      this.users = res.data;
      this.totalPages = res.totalPages;
    });
  }

  onPageChange(pageNumber) {
    this.currentPage = pageNumber;

    this.getUsers();
  }

  onSearch() {
    this.getUsers();
  }

  onSortByColumnChange(column) {
    if (this.sortByColumn == column) {
      this.sortAscending = !this.sortAscending;
    }
    else {
      this.sortAscending = true;
    }

    this.sortByColumn = column;

    this.getUsers();
  }
}
