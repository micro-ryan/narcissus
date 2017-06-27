export class App {
    Application: string
    WebServers: Server[]
}

export class Server {
    Machine: string
    PlatForm: string
    Applications:App[]
}