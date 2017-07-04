import { NgModule } from '@angular/core'
import { Routes, Router, RouterModule} from '@angular/router'
import { CommonModule } from '@angular/common'
import { AccountService } from '../../Services/AccountService'
import { AuthGuard } from './AuthGuard'
import { AnonymousGuard } from './AnonymousGuard'
import { LogonComponent } from './LogonComponent'
import { RegisterComponent } from './RegisterComponent'
import { ProfileComponent } from './ProfileComponent'
import { SendCodeComponent } from './SendCodeComponent'
import { VerifyCodeComponent } from './VerifyCodeComponent'
const accountRoutes:Routes = [
    {
        path: 'myaccount',
        children: [
            {
                path: '',
                children: [
                    {
                        path: 'logon',
                        component: LogonComponent,
                        canActivate: [AnonymousGuard]
                    },
                    {
                        path: 'forgotpassword',
                        component: LogonComponent,
                        canActivate: [AnonymousGuard]
                    },
                    {
                        path: '',
                        component: ProfileComponent,
                        canActivate: [AuthGuard]
                    }
                ]
            }
        ]
    }
]

@NgModule({
    imports: [CommonModule,  RouterModule.forChild(accountRoutes)],
    declarations: [LogonComponent, RegisterComponent, ProfileComponent],
    providers: [AuthGuard, AnonymousGuard, AccountService],
    exports: [RouterModule]
})
export class AccountModule {
    constructor() {

    }
}