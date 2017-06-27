import { NgModule, Injectable } from "@angular/core";
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { HttpModule, JsonpModule, Http, Response, Headers, RequestOptions } from "@angular/http";
import { Observable } from 'rxjs';
import { PerformanceComponent } from './PerformanceComponent'
import { ServerListComponent } from './ServerListComponent'
import { ServerListService } from '../../Services/ServerListService'
const defectRoutes: Routes = [
    {
        path: 'perf', component: ServerListComponent,
        children: [
            { path: '', component: PerformanceComponent },
            { path: ':appName', component: PerformanceComponent },
            { path: ':appName/:machinename', component: PerformanceComponent },
            { path: '**', component: PerformanceComponent }
        ]
    }
];
@NgModule({
    imports: [
        BrowserModule, FormsModule, CommonModule, ReactiveFormsModule, HttpModule, JsonpModule, RouterModule.forChild(defectRoutes)
    ],
    declarations: [ServerListComponent,PerformanceComponent],
    exports: [
        RouterModule
    ],
    providers: [ServerListService]
})
export class PerformanceModule {

}

