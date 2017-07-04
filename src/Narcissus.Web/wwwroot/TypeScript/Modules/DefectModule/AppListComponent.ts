import { Component, OnInit } from '@angular/core';
import { App } from '../../Models/AppList'
import { AppListService } from '../../Services/AppListService'
import { Observable } from 'rxjs'
import 'reflect-metadata'

@Component({
    selector: 'app-list',
    templateUrl: '/html/AppListComponent.html'
})
export class AppListComponent implements OnInit {
    apps: App[];
    selectedApp: App;
    constructor(private appListService: AppListService) {

    }

    ngOnInit(): void {
        this.appListService.GetAppList().then((res) => this.apps = res);
    }
}