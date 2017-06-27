import { NgModule } from "@angular/core";
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { HttpModule, JsonpModule, Http, Response, Headers, RequestOptions } from "@angular/http";
import { Observable } from 'rxjs';
import { UsageComponent } from './UsageComponent'


const usageRoutes: Routes = [
    { path: 'profile', component: UsageComponent }
];



@NgModule({
    imports: [BrowserModule, FormsModule, CommonModule, ReactiveFormsModule, HttpModule, JsonpModule, RouterModule.forChild(usageRoutes)],
    declarations: [UsageComponent],
    exports: [RouterModule]
})
export class UsageModule {

}

