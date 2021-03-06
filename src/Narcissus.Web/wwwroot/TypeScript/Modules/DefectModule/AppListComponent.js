"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var AppListService_1 = require("../../Services/AppListService");
require("reflect-metadata");
var AppListComponent = (function () {
    function AppListComponent(appListService) {
        this.appListService = appListService;
    }
    AppListComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.appListService.GetAppList().then(function (res) { return _this.apps = res; });
    };
    return AppListComponent;
}());
AppListComponent = __decorate([
    core_1.Component({
        selector: 'app-list',
        templateUrl: '/wwwroot/html/AppListComponent.html'
    }),
    __metadata("design:paramtypes", [AppListService_1.AppListService])
], AppListComponent);
exports.AppListComponent = AppListComponent;
//# sourceMappingURL=AppListComponent.js.map