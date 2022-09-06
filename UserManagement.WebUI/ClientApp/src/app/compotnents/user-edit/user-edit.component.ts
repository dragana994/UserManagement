import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { User } from 'src/app/models/User';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-user-edit',
  templateUrl: './user-edit.component.html',
  styleUrls: ['./user-edit.component.css']
})
export class UserEditComponent implements OnInit {
  id: number;
  formData: FormGroup;
  user: User;
  private sub: any;

  constructor(private userService: UserService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit() {
    this.formData = new FormGroup({
      id: new FormControl('', [Validators.required]),
      firstName: new FormControl('', [Validators.required, Validators.maxLength(50)]),
      lastName: new FormControl('', [Validators.required, Validators.maxLength(50)]),
      email: new FormControl('', [Validators.maxLength(100), Validators.email]),
      active: new FormControl()
    });

    this.sub = this.route.params.subscribe(params => {
      this.id = +params['id'];
      this.userService.getUser(this.id).subscribe(res => {
        this.user = res;
        this.formData.controls['id'].setValue(this.user.id);
        this.formData.controls['firstName'].setValue(this.user.firstName);
        this.formData.controls['lastName'].setValue(this.user.lastName);
        this.formData.controls['email'].setValue(this.user.email);
        this.formData.controls['active'].setValue(this.user.active);
      }
      );
    });
  }

  get firstNameValue() {
    return this.formData.get('firstName');
  }

  get emailValue() {
    return this.formData.get('email');
  }

  get lastNameValue() {
    return this.formData.get('lastName');
  }

  onEditSubmit(data: any) {
    let modifiedUser = {
      id: data.id,
      firstName: data.firstName,
      lastName: data.lastName,
      email: data.email,
      active: data.active
    }

    this.userService.editUser(modifiedUser).subscribe(res => this.router.navigate(['/user-list']));
  }

  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }
}