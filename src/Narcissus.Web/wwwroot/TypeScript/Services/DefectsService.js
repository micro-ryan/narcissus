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
var http_1 = require("@angular/http");
var QueryApp_1 = require("../Models/QueryApp");
var DefectsService = (function () {
    function DefectsService(http) {
        this.http = http;
        this.apiPath = 'http://localhost:59860/api/v1/catalog/app/';
    }
    DefectsService.prototype.GetDefectsByApp = function (applicationName) {
        return this.http.post(this.apiPath, new QueryApp_1.QueryApp(applicationName, null)).toPromise().then(this.mapResponse).catch(this.handleError);
    };
    DefectsService.prototype.GetDefectsByAppAndMachine = function (applicationName, machineName) {
        return this.http.post(this.apiPath, new QueryApp_1.QueryApp(applicationName, machineName)).toPromise().then(this.mapResponse).catch(this.handleError);
    };
    DefectsService.prototype.mapResponse = function (res) {
        var body = res.json();
        return body;
    };
    DefectsService.prototype.handleError = function (error) {
        //TODO: replace with insights client log
        var errMsg;
        if (error instanceof http_1.Response) {
            var body = error.json() || '';
            var err = body.error || JSON.stringify(body);
            errMsg = error.status + " - " + (error.statusText || '') + " " + err;
        }
        else {
            errMsg = error.message ? error.message : error.toString();
        }
        console.error(errMsg);
        return Promise.reject(errMsg);
    };
    return DefectsService;
}());
DefectsService = __decorate([
    core_1.Injectable(),
    __metadata("design:paramtypes", [http_1.Http])
], DefectsService);
exports.DefectsService = DefectsService;
//# sourceMappingURL=DefectsService.js.map