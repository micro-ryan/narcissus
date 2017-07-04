"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var http_1 = require("@angular/http");
var ServiceBase = (function () {
    function ServiceBase(http, logger) {
        this.http = http;
        this.logger = logger;
        this.BaseURL = new URL("http://localhost:59860/api/v1");
    }
    ServiceBase.prototype.GetServiceURL = function (url) {
        return new URL(url, this.BaseURL.href);
    };
    ServiceBase.prototype.handleError = function (error) {
        var errMsg;
        if (error instanceof http_1.Response) {
            var body = error.json() || '';
            var err = body.error || JSON.stringify(body);
            errMsg = error.status + " - " + (error.statusText || '') + " " + err;
        }
        else {
            errMsg = error.message ? error.message : error.toString();
        }
        this.logger.LogError(errMsg);
        return Promise.reject(errMsg);
    };
    return ServiceBase;
}());
exports.ServiceBase = ServiceBase;
//# sourceMappingURL=ServiceBase.js.map