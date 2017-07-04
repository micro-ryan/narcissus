import { NgModule, Injectable } from "@angular/core";
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { HttpModule, JsonpModule, Http, Response, Headers, RequestOptions } from "@angular/http";
import { Observable } from 'rxjs';

import { LoggerService } from '../../Services/LoggerService'
import { StartupComponents } from './StartupComponents'
import { PageNotFoundComponent } from './PageNotFoundComponent'
import { DefectModule } from '../DefectModule/DefectModule'
import { PerformanceModule } from '../PerformanceModule/PerformanceModule'
import { ProfileModule } from '../ProfileModule/ProfileModule'
import { UsageModule } from '../UsageModule/UsageModule'
import { AccountModule } from '../Account/AccountModule'
const appRoutes: Routes = [
    { path: '', redirectTo: '/myaccount', pathMatch:'full' }
    ]

@NgModule({
    imports: [BrowserModule, FormsModule, CommonModule, ReactiveFormsModule, HttpModule, JsonpModule, AccountModule,  RouterModule.forRoot(appRoutes)],
    declarations: [StartupComponents, PageNotFoundComponent],
    bootstrap: [StartupComponents],
    providers: [LoggerService],
    exports: [RouterModule]
})
export class BootstrapModule {

}

