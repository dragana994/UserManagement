import { Component, Input, OnDestroy, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { User } from 'src/app/models/User';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-user-detail',
  templateUrl: './user-detail.component.html',
  styleUrls: ['./user-detail.component.css']
})
export class UserDetailComponent implements OnInit, OnDestroy {
  id: number;
  user: User;
  private sub: any;

  constructor(private userService: UserService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
      this.id = +params['id'];
      this.userService.getUser(this.id).subscribe(res => this.user = res);
    });
  }

  editUser() {
    this.router.navigate(['/user-edit', this.id]);
  }

  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }
}