"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var common_1 = require("@angular/common");
var router_1 = require("@angular/router");
var forms_1 = require("@angular/forms");
var platform_browser_1 = require("@angular/platform-browser");
var http_1 = require("@angular/http");
var AppListComponent_1 = require("./AppListComponent");
var DefectListComponent_1 = require("./DefectListComponent");
//import { DefectComponent } from './DefectComponent'
var AppListService_1 = require("../../Services/AppListService");
var DefectsService_1 = require("../../Services/DefectsService");
var defectRoutes = [
    {
        path: 'defects', component: AppListComponent_1.AppListComponent,
        children: [
            { path: '', component: DefectListComponent_1.DefectListComponent },
            { path: ':appName', component: DefectListComponent_1.DefectListComponent },
            { path: ':appName/:machinename', component: DefectListComponent_1.DefectListComponent },
            { path: '**', component: DefectListComponent_1.DefectListComponent }
        ]
    }
];
var DefectModule = (function () {
    function DefectModule() {
    }
    return DefectModule;
}());
DefectModule = __decorate([
    core_1.NgModule({
        imports: [
            platform_browser_1.BrowserModule, forms_1.FormsModule, common_1.CommonModule, forms_1.ReactiveFormsModule, http_1.HttpModule, http_1.JsonpModule, router_1.RouterModule.forChild(defectRoutes)
        ],
        declarations: [AppListComponent_1.AppListComponent, DefectListComponent_1.DefectListComponent],
        exports: [
            router_1.RouterModule
        ],
        providers: [AppListService_1.AppListService, DefectsService_1.DefectsService]
    })
], DefectModule);
exports.DefectModule = DefectModule;
//# sourceMappingURL=DefectModule.js.map