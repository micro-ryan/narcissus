import { Injectable } from '@angular/core'
import { Http, Response } from '@angular/http'
import { App } from '../Models/AppList'

@Injectable()
export class AppListService {
    private apiPath: string = 'http://localhost:59860/api/v1/catalog/'
   
    constructor(private http: Http) {

    }
    GetAppList(): Promise<App[]> {
        return this.http.get(this.apiPath).toPromise().then(this.mapResponse).catch(this.handleError);
    }

    private mapResponse(res: Response) {
        let body = res.json();
        return body as App[]; 
    }

    private handleError(error: Response | any) {
        //TODO: replace with insights client log
        let errMsg: string;
        if (error instanceof Response) {
            const body = error.json() || '';
            const err = body.error || JSON.stringify(body);
            errMsg = `${error.status} - ${error.statusText || ''} ${err}`;
        } else {
            errMsg = error.message ? error.message : error.toString();
        }
        console.error(errMsg);
        return Promise.reject(errMsg);
    }
}
