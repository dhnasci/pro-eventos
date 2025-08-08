import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any = [];
  larguraImg = 150;
  margemImg = 2;
  isImgCollapsed = false;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEventos();
  }

  public getEventos(): void {
    this.http.get('https://localhost:44355/api/Evento').subscribe(
      response => this.eventos = response,
      error => console.log(error)
    );
  }

  public alteraImagem(): void {
    this.isImgCollapsed = !this.isImgCollapsed;
  }

}
