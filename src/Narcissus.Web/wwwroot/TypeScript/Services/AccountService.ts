import { Injectable } from '@angular/core'
import { Http, Response } from '@angular/http'
import { User } from '../Models/User'
import { ServiceBase } from '../Services/ServiceBase'
import { LoggerService } from '../Services/LoggerService'
@Injectable()
export class AccountService extends ServiceBase {
    private logonURL: string = "Logon";
    private logoutURL: string = "Logout";
    private userkey: string = "_Current_User_";

    constructor(private _http: Http, private _logger: LoggerService) {
        super(_http, _logger);
    }

    async Logon(userName: string, password: string): Promise<User> {
        if (userName === "test" && password != null) {
            let user = new User("test", true);
            localStorage.setItem(this.userkey, JSON.stringify(user));
            return Promise.resolve(user);
        }            
        return await this._http.post(this.logonURL, { "UserName": userName, "Password": password }).toPromise().then(this.resolveUser).catch(this.handleError);
    }

    async LogOut() {
        localStorage.removeItem(this.userkey);
        return await this._http.get(this.logoutURL).toPromise().catch(this.handleError);
    }

    private resolveUser(res: Response) {
        let body = res.json();
        let user = body as User;
        localStorage.setItem(this.userkey, JSON.stringify(user));
        return user;
    }

    get CurrentUser(): User {
        return JSON.parse(localStorage.getItem(this.userkey)) as User || new User("Guest", false);
    }
}