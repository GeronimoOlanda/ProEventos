import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {
    public eventos: any = [{
      Tema: 'Angular',
      Local: 'São Paulo'
    },{
      Tema: 'TypeScript',
      Local: 'Roraima'
    },
    {
      Tema: 'JavaScript',
      Local: 'Amapá'
    }
  ]

  constructor() { }

  ngOnInit(): void {
  }

}
