import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { User } from 'src/app/models/User';
import { UserListQuery } from 'src/app/models/UserListQuery';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.css']
})
export class UserListComponent implements OnInit {
  users: User[];

  currentPage: number = 1;
  totalPages: number;

  searchByFirstName: string = "";
  searchByLastName: string = "";
  sortByColumn = "id";
  sortAscending = true;

  constructor(private userService: UserService, private router: Router) { }

  ngOnInit() {
    this.getUsers();
  }

  addUser() {
    this.router.navigate(['/user-add']);
  }

  deleteUser(evt, id) {
    evt.preventDefault();
    if (confirm("Are you sure to delete the user?")) {
      this.userService.deleteUser(id)
        .subscribe(data =>
          this.getUsers());
    }
  }

  getUsers() {
    let query: UserListQuery = {
      firstName: this.searchByFirstName,
      lastName: this.searchByLastName,
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
