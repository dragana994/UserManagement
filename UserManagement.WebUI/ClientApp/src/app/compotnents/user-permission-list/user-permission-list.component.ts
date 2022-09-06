import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Permission } from 'src/app/models/Permission';
import { UserPermissionListQuery } from 'src/app/models/UserPermissionListQuery';
import { PermissionService } from 'src/app/services/permission.service';

@Component({
  selector: 'app-user-permission-list',
  templateUrl: './user-permission-list.component.html',
  styleUrls: ['./user-permission-list.component.css']
})
export class UserPermissionListComponent implements OnInit {
  permissions: Permission[];
  @Input() userId: number;

  currentPage: number = 1;
  totalPages: number;
  sortByColumn = "id";
  sortAscending = true;

  constructor(private permissionService: PermissionService, private router: Router) { }

  ngOnInit() {
    let query: UserPermissionListQuery = {
      userId: this.userId,
      detailMode: true,
      page: this.currentPage,
      pageSize: 10,
      sortColumnName: this.sortByColumn,
      sortAscending: this.sortAscending
    };

    this.permissionService.getPermissions(query).subscribe(res => {
      this.permissions = res.data;
      this.totalPages = res.totalPages;
    });
  }
}