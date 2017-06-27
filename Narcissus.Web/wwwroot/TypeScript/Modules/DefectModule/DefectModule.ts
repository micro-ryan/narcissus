import { NgModule, Injectable } from "@angular/core";
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { HttpModule, JsonpModule, Http, Response, Headers, RequestOptions } from "@angular/http";
import { Observable } from 'rxjs';
import { AppListComponent } from './AppListComponent'
import { DefectListComponent } from './DefectListComponent'
//import { DefectComponent } from './DefectComponent'
import { AppListService } from '../../Services/AppListService'
import { DefectsService } from '../../Services/DefectsService'
const defectRoutes: Routes = [
    {
        path: 'defects', component: AppListComponent,
        children: [
            { path: '', component: DefectListComponent },
            { path: ':appName', component: DefectListComponent },
            { path: ':appName/:machinename', component: DefectListComponent },
            { path: '**', component: DefectListComponent }
        ]
    }
];
@NgModule({
    imports: [
        BrowserModule, FormsModule, CommonModule, ReactiveFormsModule, HttpModule, JsonpModule, RouterModule.forChild(defectRoutes)
    ],
    declarations: [AppListComponent, DefectListComponent],
    exports: [
        RouterModule
    ],
    providers: [AppListService,DefectsService]
})
export class DefectModule {

}

