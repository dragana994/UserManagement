import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-pagination',
  templateUrl: './pagination.component.html',
  styleUrls: ['./pagination.component.css']
})
export class PaginationComponent implements OnInit {

  @Input() currentPage: number;
  @Input() totalPages: number;

  @Output() pageChange = new EventEmitter<number>();

  constructor() { }

  ngOnInit() {
  }

  onClickNext() {
    this.pageChange.emit(this.currentPage + 1);
  }

  onClickPrevious() {
    this.pageChange.emit(this.currentPage - 1);
  }
}
