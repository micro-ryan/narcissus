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
var DefectComponent = (function () {
    function DefectComponent(route, router, defectsService) {
        this.route = route;
        this.router = router;
        this.defectsService = defectsService;
    }
    DefectComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.route.params.toPromise().then(function (params) { return _this.getDefects(params["appName"], params['machineName']); });
    };
    DefectComponent.prototype.getDefects = function (appName, machineName) {
        var _this = this;
        if (appName == null || appName.length <= 0)
            return;
        if (machineName == null && appName.length <= 0) {
            this.defectsService.GetDefectsByApp(appName).then(function (res) { return _this.logs = res; });
        }
        else {
            this.defectsService.GetDefectsByAppAndMachine(appName, machineName).then(function (res) { return _this.logs = res; });
        }
    };
    return DefectComponent;
}());
DefectComponent = __decorate([
    core_1.Component({
        templateUrl: '/html/DefectComponent.html'
    }),
    __metadata("design:paramtypes", [router_1.ActivatedRoute, router_1.Router, DefectsService_1.DefectsService])
], DefectComponent);
exports.DefectComponent = DefectComponent;
//# sourceMappingURL=DefectComponent.js.map