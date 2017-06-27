import 'core-js/es6';
import 'core-js/es7/reflect';
import 'zone.js';
import '@angular/common';
import '@angular/compiler';
import '@angular/core';
import '@angular/forms'
import '@angular/http';
import '@angular/platform-browser';
import '@angular/platform-browser-dynamic';
import '@angular/router';
// RxJS
import 'rxjs';

import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { BootstrapModule } from './Modules/BootstrapModule/BootstrapModule';
platformBrowserDynamic().bootstrapModule(BootstrapModule);

