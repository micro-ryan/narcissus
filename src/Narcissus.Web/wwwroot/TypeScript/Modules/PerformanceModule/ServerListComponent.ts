import { Component, OnInit } from '@angular/core';
import { Server } from '../../Models/AppList'
import { ServerListService } from '../../Services/ServerListService'
import { Observable } from 'rxjs'
import 'reflect-metadata'

@Component({
    templateUrl: '/html/ServerListComponent.html'
})
export class ServerListComponent implements OnInit {
    servs: Server[];
    selectedServ: Server;
    constructor(private servListService:ServerListService) {

    }

    ngOnInit(): void {
        this.servListService.GetServerList().then((res) => this.servs = res);
    }
}