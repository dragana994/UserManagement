import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-user-add',
  templateUrl: './user-add.component.html',
  styleUrls: ['./user-add.component.css']
})
export class UserAddComponent implements OnInit {
  formData: FormGroup;

  constructor(private userService: UserService, private router: Router) { }

  ngOnInit() {
    this.formData = new FormGroup({
      firstName: new FormControl('', [Validators.required, Validators.maxLength(50)]),
      lastName: new FormControl('', [Validators.required, Validators.maxLength(50)]),
      username: new FormControl('', [Validators.required, Validators.maxLength(50)]),
      password: new FormControl('', [Validators.required, Validators.maxLength(50), Validators.minLength(8)]),
      email: new FormControl('', [Validators.maxLength(100), Validators.email])
    });
  }

  get firstNameValue() {
    return this.formData.get('firstName');
  }

  get lastNameValue() {
    return this.formData.get('lastName');
  }

  get usernameValue() {
    return this.formData.get('username');
  }

  get passwordValue() {
    return this.formData.get('password');
  }

  get emailValue() {
    return this.formData.get('email');
  }

  onAddSubmit(data: any) {
    let newUser = {
      firstName: data.firstName,
      lastName: data.lastName,
      username: data.username,
      password: data.password,
      email: data.email
    }

    this.userService.addUser(newUser).subscribe(res => this.router.navigate(['/user-list']));
  }

}
