import { EventEmitter,Component, OnInit, Input, Output } from '@angular/core';

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})
export class TableComponent implements OnInit {

  @Input() data: any[] = [];
  @Input() propsName: string[] = [];
  @Input() showDateSearch: boolean;
  dataCopy: any[] = [];
  dataLoadedFirstTimeAfterUpdate = false;
  @Input() columnNames: string[];
  @Output() getData = new EventEmitter<any>();
  @Output() updateData = new EventEmitter<any>();
  @Output() dateSearch = new EventEmitter();

  private isExpanded = false;
  private maxTableData = 50;
  private pageStart = 0;

  ngOnInit() {
    this.getData.emit();
  }

  prevData() {
    this.pageStart = this.pageStart - this.maxTableData <= 0 ? 0 : this.pageStart - this.maxTableData;
    if (this.maxTableData === null) this.pageStart = 0;
  }

  nextData() {
    this.pageStart = this.pageStart + this.maxTableData > this.data.length ? this.pageStart : this.pageStart + this.maxTableData;
    if (this.maxTableData === null) this.pageStart = 0;
  }

  getDataFromDb() {
    this.getData.emit();
  }

  saveData(newData: any, propName: string, values) {
    if (values.oldValue != values.newValue) {
      newData[propName] = values.newValue;
      this.updateData.emit(newData);
      this.dataLoadedFirstTimeAfterUpdate = false;
    }
    this.dataCopy = this.data.slice();
  }

  onSearcQueryChanges(searchQuery) {
    if (!this.dataLoadedFirstTimeAfterUpdate) {
      this.dataCopy = this.data.slice();
      this.dataLoadedFirstTimeAfterUpdate = !this.dataLoadedFirstTimeAfterUpdate;
    }
    if (searchQuery) {
      let newData = [];
      for (let dataItem of this.dataCopy) {
        if (this.containsSearchQuery(dataItem, searchQuery)) newData.push(dataItem);
      }
      this.data = newData.slice();
    } else {
      this.getData.emit();
    }
    this.pageStart = 0;
  }

  containsSearchQuery(data: any, searchQuery: string): boolean {
    for (let prop of this.propsName) {
      if (data[prop]) {
        if (data[prop].toString().includes(searchQuery)) return true;
      }
    }
    return false;
  }

  onShowPerPage(value) {
    if (value === null || value === '' || value === undefined) {
      this.pageStart = 0;
      this.maxTableData = 50;
    } else {
      this.maxTableData =+value;
    }
  }

  onDateSearch(from, to) {
    this.dateSearch.emit({'from': from,'to': to });
  }

  onCollapse() {
    this.isExpanded = !this.isExpanded;
  }
}

