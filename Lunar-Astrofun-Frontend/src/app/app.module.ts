import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';

import { HomeModule } from './home/home.module';
import { AboutModule } from './about/about.module';

import 'bootstrap/dist/css/bootstrap.css';
import '../styles/main.css';

@NgModule({
    imports: [
        BrowserModule,
        AppRoutingModule,
        HomeModule,
        AboutModule
    ],
    declarations: [AppComponent],
    bootstrap: [AppComponent]
})

export class AppModule {}
