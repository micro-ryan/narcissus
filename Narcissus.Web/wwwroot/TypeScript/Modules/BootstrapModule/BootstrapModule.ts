import { NgModule, Injectable } from "@angular/core";
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { HttpModule, JsonpModule, Http, Response, Headers, RequestOptions } from "@angular/http";
import { Observable } from 'rxjs';
import { StartupComponents } from './StartupComponents'
import { PageNotFoundComponent } from './PageNotFoundComponent'
import { DefectModule } from '../DefectModule/DefectModule'
import { PerformanceModule } from '../PerformanceModule/PerformanceModule'
import { ProfileModule } from '../ProfileModule/ProfileModule'
import { UsageModule } from '../UsageModule/UsageModule'

const appRoutes: Routes = [
    { path: '', redirectTo: '/defects', pathMatch:'full' },
    { path: '**', component: PageNotFoundComponent },
    ]

@NgModule({
    imports: [BrowserModule, FormsModule, CommonModule, ReactiveFormsModule, HttpModule, JsonpModule, DefectModule, PerformanceModule, ProfileModule, UsageModule, RouterModule.forRoot(appRoutes)],
    declarations: [StartupComponents, PageNotFoundComponent],
    bootstrap: [StartupComponents],
    exports: [RouterModule]
})
export class BootstrapModule {

}

