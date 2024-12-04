import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

interface Cases {
  CaseNumber: string;
  Defendent: string;
  Plaintiff: string;
  Officer: string;
  BadgeNumber: number;
  DescriptionOfInicident: string;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  public cases: Cases[] = [];

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getCases();
  }

  getCases() {
    this.http.get<Cases[]>('/cases').subscribe(
      (result) => {
        this.cases = result;
      },
      (error) => {
        console.error(error);
      }
    );
  }

  title = 'crud-with-net-9-angular-17.client';
}
