import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Permission } from 'src/app/models/Permission';
import { UserPermissionListQuery } from 'src/app/models/UserPermissionListQuery';
import { PermissionService } from 'src/app/services/permission.service';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-user-assign',
  templateUrl: './user-assign.component.html',
  styleUrls: ['./user-assign.component.css']
})
export class UserAssignComponent implements OnInit, OnDestroy {
  title: string = "Assign permissions";
  permissions: Permission[];
  userId: number;
  private sub: any;
  currentPage: number = 1;
  totalPages: number;
  sortByColumn = "id";
  sortAscending = true;

  constructor(private permissionService: PermissionService, private userService: UserService, private route: ActivatedRoute, private router: Router) { }

  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
      this.userId = +params['id'];

      let query: UserPermissionListQuery = {
        userId: this.userId,
        detailMode: false,
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
    );
  }

  onAssignSubmit(data: any) {
    let user = {
      userId: this.userId,
      permissionIds: this.permissions.filter(x => x.assign).map(x => x.id)
    };

    this.userService.assignUser(user).subscribe(res => this.router.navigate(['/user-details', this.userId]));
  }
}
