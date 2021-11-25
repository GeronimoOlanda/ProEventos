import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {
    public eventos: any;

  constructor(private http: HttpClient) { } // criando uma variavel privada e setando o tipo dela como o de HttpClient

  //metodo que é chamado antes de inicializar a aplicação
  ngOnInit(): void {
    this.getEventos();
  }

  public getEventos(): void{
    this.http.get(`http://localhost:5000/api/evento`).subscribe(
      response => this.eventos = response,
      error => console.log(error),
    );
  }
}
