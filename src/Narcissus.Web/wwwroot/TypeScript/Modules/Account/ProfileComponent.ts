import { Component, OnInit } from '@angular/core';
import {AccountService } from '../../Services/AccountService'

@Component({
    templateUrl: '/html/Account/ProfileComponent.html'
})
export class ProfileComponent implements OnInit {

    constructor(accountService: AccountService) {

    }

    ngOnInit(): void {

    }
}