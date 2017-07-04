import { Http, Response } from '@angular/http'
import { LoggerService } from '../Services/LoggerService'
export class ServiceBase{
    protected BaseURL: URL = new URL("http://localhost:59860/api/v1");

    constructor(private http: Http, private logger:LoggerService) {

    }

    protected GetServiceURL(url: string) {
        return new URL(url, this.BaseURL.href);
    }
    protected handleError(error: Response | any) {
        let errMsg: string;
        if (error instanceof Response) {
            const body = error.json() || '';
            const err = body.error || JSON.stringify(body);
            errMsg = `${error.status} - ${error.statusText || ''} ${err}`;
        } else {
            errMsg = error.message ? error.message : error.toString();
        }
        this.logger.LogError(errMsg);
        return Promise.reject(errMsg);
    }
}