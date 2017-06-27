import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute, Params } from '@angular/router';
import { LogDTO } from '../../Models/LogDTO'
import { Observable } from 'rxjs'
import 'rxjs/add/operator/switchMap';
import { DefectsService } from '../../Services/DefectsService'
@Component({
    templateUrl: '/wwwroot/html/DefectListComponent.html'
})
export class DefectListComponent implements OnInit {
    private selectedApp: string;
    private selectedMachine: string;
    logs: LogDTO[];
    constructor(private route: ActivatedRoute, private router: Router, private defectsService: DefectsService) {
        console.log("getDefects1")
    }

    ngOnInit(): void {
        console.log("getDefects2")
        this.route.params.subscribe((params: Params) => this.getDefects(params["appName"], params['machineName']));
    }

    private getDefects(appName: string, machineName: string) {
        console.log("getDefects")
        console.log(appName);
        console.log(machineName);
        if (appName == null || appName.length <= 0)
            return;

        if (machineName == null || machineName.length <= 0) {
            this.defectsService.GetDefectsByApp(appName).then((res) => this.logs = res);
        }
        else {
            this.defectsService.GetDefectsByAppAndMachine(appName, machineName).then((res) => this.logs = res);
        }
    }
}