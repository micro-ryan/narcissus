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
var LoggerService_1 = require("../../Services/LoggerService");
var StartupComponents_1 = require("./StartupComponents");
var PageNotFoundComponent_1 = require("./PageNotFoundComponent");
var AccountModule_1 = require("../Account/AccountModule");
var appRoutes = [
    { path: '', redirectTo: '/myaccount', pathMatch: 'full' }
];
var BootstrapModule = (function () {
    function BootstrapModule() {
    }
    return BootstrapModule;
}());
BootstrapModule = __decorate([
    core_1.NgModule({
        imports: [platform_browser_1.BrowserModule, forms_1.FormsModule, common_1.CommonModule, forms_1.ReactiveFormsModule, http_1.HttpModule, http_1.JsonpModule, AccountModule_1.AccountModule, router_1.RouterModule.forRoot(appRoutes)],
        declarations: [StartupComponents_1.StartupComponents, PageNotFoundComponent_1.PageNotFoundComponent],
        bootstrap: [StartupComponents_1.StartupComponents],
        providers: [LoggerService_1.LoggerService],
        exports: [router_1.RouterModule]
    })
], BootstrapModule);
exports.BootstrapModule = BootstrapModule;
//# sourceMappingURL=BootstrapModule.js.map