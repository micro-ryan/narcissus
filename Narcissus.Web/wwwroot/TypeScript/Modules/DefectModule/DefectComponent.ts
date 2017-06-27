import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute, Params } from '@angular/router';
import { LogDTO } from '../../Models/LogDTO'
import { Observable } from 'rxjs'
import 'rxjs/add/operator/switchMap';
import { DefectsService } from '../../Services/DefectsService'
@Component({
    templateUrl: '/wwwroot/html/DefectComponent.html'
})
export class DefectComponent implements OnInit {
    private selectedApp: string;
    private selectedMachine: string;
    logs: LogDTO[];
    constructor(private route: ActivatedRoute, private router: Router, private defectsService: DefectsService) {

    }

    ngOnInit(): void {
        this.route.params.toPromise().then((params: Params) => this.getDefects(params["appName"], params['machineName']));
    }

    private getDefects(appName: string, machineName: string) {
        if (appName == null || appName.length <= 0)
            return;

        if (machineName == null && appName.length <= 0) {
            this.defectsService.GetDefectsByApp(appName).then((res) => this.logs = res);
        }
        else {
            this.defectsService.GetDefectsByAppAndMachine(appName, machineName).then((res) => this.logs = res);
        }
    }
}