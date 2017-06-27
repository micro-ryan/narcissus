import { NgModule } from "@angular/core";
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { HttpModule, JsonpModule, Http, Response, Headers, RequestOptions } from "@angular/http";
import { Observable } from 'rxjs';
import { ProfileComponent } from './ProfileComponent'

const profileRoutes: Routes = [
    { path: 'profile', component: ProfileComponent }
];


@NgModule({
    imports: [BrowserModule, FormsModule, CommonModule, ReactiveFormsModule, HttpModule, JsonpModule, RouterModule.forChild(profileRoutes)],
    declarations: [ProfileComponent],
    exports: [RouterModule]
})
export class ProfileModule {

}

