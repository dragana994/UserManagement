import { Component, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { User } from '../../models/User';

@Component({
  selector: 'app-user-delete-modal',
  templateUrl: './user-delete-modal.component.html',
  styleUrls: ['./user-delete-modal.component.css']
})
export class UserDeleteModalComponent implements OnInit {
  public user: User;

  constructor(public modal: NgbActiveModal) { }
  ngOnInit() {
  }

  close(result: string) {
    this.modal.close(result);
  }
}
