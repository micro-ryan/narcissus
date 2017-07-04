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
var common_1 = require("@angular/common");
var AccountService_1 = require("../../Services/AccountService");
var AuthGuard_1 = require("./AuthGuard");
var AnonymousGuard_1 = require("./AnonymousGuard");
var LogonComponent_1 = require("./LogonComponent");
var RegisterComponent_1 = require("./RegisterComponent");
var ProfileComponent_1 = require("./ProfileComponent");
var accountRoutes = [
    {
        path: 'myaccount',
        children: [
            {
                path: '',
                children: [
                    {
                        path: 'logon',
                        component: LogonComponent_1.LogonComponent,
                        canActivate: [AnonymousGuard_1.AnonymousGuard]
                    },
                    {
                        path: 'forgotpassword',
                        component: LogonComponent_1.LogonComponent,
                        canActivate: [AnonymousGuard_1.AnonymousGuard]
                    },
                    {
                        path: '',
                        component: ProfileComponent_1.ProfileComponent,
                        canActivate: [AuthGuard_1.AuthGuard]
                    }
                ]
            }
        ]
    }
];
var AccountModule = (function () {
    function AccountModule() {
    }
    return AccountModule;
}());
AccountModule = __decorate([
    core_1.NgModule({
        imports: [common_1.CommonModule, router_1.RouterModule.forChild(accountRoutes)],
        declarations: [LogonComponent_1.LogonComponent, RegisterComponent_1.RegisterComponent, ProfileComponent_1.ProfileComponent],
        providers: [AuthGuard_1.AuthGuard, AnonymousGuard_1.AnonymousGuard, AccountService_1.AccountService],
        exports: [router_1.RouterModule]
    }),
    __metadata("design:paramtypes", [])
], AccountModule);
exports.AccountModule = AccountModule;
//# sourceMappingURL=AccountModule.js.map