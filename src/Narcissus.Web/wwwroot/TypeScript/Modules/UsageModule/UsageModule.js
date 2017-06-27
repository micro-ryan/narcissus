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
var UsageComponent_1 = require("./UsageComponent");
var usageRoutes = [
    { path: 'profile', component: UsageComponent_1.UsageComponent }
];
var UsageModule = (function () {
    function UsageModule() {
    }
    UsageModule = __decorate([
        core_1.NgModule({
            imports: [platform_browser_1.BrowserModule, forms_1.FormsModule, common_1.CommonModule, forms_1.ReactiveFormsModule, http_1.HttpModule, http_1.JsonpModule, router_1.RouterModule.forChild(usageRoutes)],
            declarations: [UsageComponent_1.UsageComponent],
            exports: [router_1.RouterModule]
        })
    ], UsageModule);
    return UsageModule;
}());
exports.UsageModule = UsageModule;
//# sourceMappingURL=UsageModule.js.map