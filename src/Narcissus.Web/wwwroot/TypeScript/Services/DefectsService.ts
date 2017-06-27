import { Injectable } from '@angular/core'
import { Http, Response } from '@angular/http'
import { LogDTO } from '../Models/LogDTO'
import { QueryApp } from '../Models/QueryApp'
import { Observable } from 'rxjs'
@Injectable()
export class DefectsService {
    private apiPath: string = 'http://localhost:59860/api/v1/catalog/app/'

    constructor(private http: Http) {

    }
    GetDefectsByApp(applicationName: string): Promise<LogDTO[]> {
        return this.http.post(this.apiPath, new QueryApp(applicationName,null)).toPromise().then(this.mapResponse).catch(this.handleError);
    }
    GetDefectsByAppAndMachine(applicationName: string, machineName: string): Promise<LogDTO[]> {
        return this.http.post(this.apiPath, new QueryApp(applicationName, machineName)).toPromise().then(this.mapResponse).catch(this.handleError);
    }
    private mapResponse(res: Response) {
        let body = res.json();
        return body as LogDTO[];
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
