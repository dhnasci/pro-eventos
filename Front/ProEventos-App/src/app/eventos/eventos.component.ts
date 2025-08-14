import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any = [];
  public eventosFiltrados: any = [];
  larguraImg = 150;
  margemImg = 2;
  isImgCollapsed = false;
  // tslint:disable-next-line:variable-name
  private _filtraLista = '';

  public get filtraLista(): string {
    return this._filtraLista;
  }

  public set filtraLista(valor: string) {
    this._filtraLista = valor;
    this.eventosFiltrados = (this.filtraLista) ? this.filtrarEventos(this.filtraLista) : this.eventos;
  }

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEventos();
  }

  public getEventos(): void {
    this.http.get('https://localhost:44355/api/Evento').subscribe(
      response => {
        this.eventos = response;
        this.eventosFiltrados = response;
      },
      error => console.log(error)
    );
  }

  public alteraImagem(): void {
    this.isImgCollapsed = !this.isImgCollapsed;
  }

  private filtrarEventos(filtraPor: string): any {
    filtraPor = filtraPor.toLowerCase();
    return this.eventos.filter(
      (evto: any) => evto.tema.toLowerCase().indexOf(filtraPor) !== -1 ||
        evto.local.toLowerCase().indexOf(filtraPor) !== -1
    );
  }

}
