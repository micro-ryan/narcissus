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
var PerformanceComponent_1 = require("./PerformanceComponent");
var ServerListComponent_1 = require("./ServerListComponent");
var ServerListService_1 = require("../../Services/ServerListService");
var defectRoutes = [
    {
        path: 'perf', component: ServerListComponent_1.ServerListComponent,
        children: [
            { path: '', component: PerformanceComponent_1.PerformanceComponent },
            { path: ':appName', component: PerformanceComponent_1.PerformanceComponent },
            { path: ':appName/:machinename', component: PerformanceComponent_1.PerformanceComponent },
            { path: '**', component: PerformanceComponent_1.PerformanceComponent }
        ]
    }
];
var PerformanceModule = (function () {
    function PerformanceModule() {
    }
    return PerformanceModule;
}());
PerformanceModule = __decorate([
    core_1.NgModule({
        imports: [
            platform_browser_1.BrowserModule, forms_1.FormsModule, common_1.CommonModule, forms_1.ReactiveFormsModule, http_1.HttpModule, http_1.JsonpModule, router_1.RouterModule.forChild(defectRoutes)
        ],
        declarations: [ServerListComponent_1.ServerListComponent, PerformanceComponent_1.PerformanceComponent],
        exports: [
            router_1.RouterModule
        ],
        providers: [ServerListService_1.ServerListService]
    })
], PerformanceModule);
exports.PerformanceModule = PerformanceModule;
//# sourceMappingURL=PerformanceModule.js.map