import { Component, OnInit, Input, ViewChild, ElementRef, Output, EventEmitter } from '@angular/core';
import * as moment from 'moment';
@Component({
  selector: 'app-table-cell',
  templateUrl: './table-cell.component.html',
  styleUrls: ['./table-cell.component.css']
})
export class TableCellComponent implements OnInit {
  @Input() value: string;
  @Output() focusOut = new EventEmitter();
  @ViewChild('cell') inputElement: ElementRef;
  enterKeyCode = 13;
  editMode: boolean = false;
  oldValue: string;

  constructor() { }

  ngOnInit() {
    const validate = moment(this.value).isValid() && this.value !== null && !Number(this.value) && this.value!== 0;
    if(validate) {
      this.value = new Date(this.value).toLocaleDateString();
    }
  }

  onClick() {
    this.oldValue = this.value;
    this.editMode = !this.editMode;
    if (this.editMode) {
      this.inputElement.nativeElement.removeAttribute('readonly');
    } else {
      this.inputElement.nativeElement.setAttribute('readonly',true);
    }
  }

  onKey(e) {
    console.log(e.keyCode)
    if (e.keyCode === this.enterKeyCode) this.onFocusOut();
  }
  onFocusOut() {
    this.editMode = false;
    console.log('focus out');
    this.focusOut.emit({ 'newValue': this.value, 'oldValue': this.oldValue });
  }
}
