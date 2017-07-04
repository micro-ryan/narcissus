import { Injectable } from '@angular/core'
import { Http, Response } from '@angular/http'
@Injectable()
export class LoggerService {
    constructor() {

    }
    LogError(message: any): void {
        console.error(message);
    }

    LogInfo(message: any): void {
        console.info(message);
    }

    LogDebug(message: any): void{
        console.debug(message);
    }
}