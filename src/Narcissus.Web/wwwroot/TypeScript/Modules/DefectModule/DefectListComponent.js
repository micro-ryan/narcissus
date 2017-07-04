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
var router_1 = require("@angular/router");
require("rxjs/add/operator/switchMap");
var DefectsService_1 = require("../../Services/DefectsService");
var DefectListComponent = (function () {
    function DefectListComponent(route, router, defectsService) {
        this.route = route;
        this.router = router;
        this.defectsService = defectsService;
        console.log("getDefects1");
    }
    DefectListComponent.prototype.ngOnInit = function () {
        var _this = this;
        console.log("getDefects2");
        this.route.params.subscribe(function (params) { return _this.getDefects(params["appName"], params['machineName']); });
    };
    DefectListComponent.prototype.getDefects = function (appName, machineName) {
        var _this = this;
        console.log("getDefects");
        console.log(appName);
        console.log(machineName);
        if (appName == null || appName.length <= 0)
            return;
        if (machineName == null || machineName.length <= 0) {
            this.defectsService.GetDefectsByApp(appName).then(function (res) { return _this.logs = res; });
        }
        else {
            this.defectsService.GetDefectsByAppAndMachine(appName, machineName).then(function (res) { return _this.logs = res; });
        }
    };
    return DefectListComponent;
}());
DefectListComponent = __decorate([
    core_1.Component({
        templateUrl: '/html/DefectListComponent.html'
    }),
    __metadata("design:paramtypes", [router_1.ActivatedRoute, router_1.Router, DefectsService_1.DefectsService])
], DefectListComponent);
exports.DefectListComponent = DefectListComponent;
//# sourceMappingURL=DefectListComponent.js.map