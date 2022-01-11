import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.css']
})
export class EventosComponent implements OnInit {

  public eventos: any = [];
  public filteredEvents: any = []; //inicializando a variavel para o filtro filtrado
  widthImg: number = 50;
  marginImg: number = 2;
  showImg: boolean = true;
  borderImg: number = 5;

  private _listFilter: string = '';
  //retorna o que foi filtrado
  public get listFilter(){
    return this._listFilter;
  }
  //pega os valores para serem filtrados
  public set listFilter(value: string){
    this._listFilter = value;
    this.filteredEvents = this.listFilter ? this.filterEvents(this.listFilter) : this.eventos // ternario para verificar os valores a serem filtrados
  }
  //fazendo o filtro para que tudo seja filtrado em letra minuscula e que seja diferente de vazio
  filterEvents(FilterBy: string): any {
    FilterBy = FilterBy.toLocaleLowerCase();
    // filtrando por tema ou local
    return this.eventos.filter(
      (evento: any) => evento.tema.toLocaleLowerCase().indexOf(FilterBy) !== -1 || evento.local.toLocaleLowerCase().indexOf(FilterBy) !== -1
    );

  }


  constructor(private http: HttpClient) {

   }

  ngOnInit(): void {
    this.getEventos()
  }
  ModifyStateImg(){
    this.showImg = !this.showImg;
  }
  public getEventos() : void {

    this.http.get('https://localhost:44367/api/Evento/').subscribe(
      response =>{
         this.eventos = response
        this.filteredEvents = this.eventos
      },
      error => console.log(error),
    );

  }

}
