import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing/app-routing.module';
import { LivroModule } from './livro/livro.module';
import { AdminLayoutModule } from './layouts/admin-layout/admin-layout.module';
import { AdminLayoutComponent } from './layouts/admin-layout/admin-layout.component';
import { SidebarModule } from './sidebar/sidebar.module';
import { NavbarModule } from './shared/navbar/navbar.module';
import { FooterModule } from './shared/footer/footer.module';
import { ApiService } from './services/api.service';
import { HttpClientModule } from '@angular/common/http';
import { SwalService } from './utils/swal/swal.service';

@NgModule({
  declarations: [
    AppComponent,
    AdminLayoutComponent
  ],
  imports: [
    BrowserModule,
    FooterModule,
    HttpClientModule,
    AdminLayoutModule,
    SidebarModule,
    NavbarModule,
    LivroModule,
    AppRoutingModule
  ],
  providers: [
    ApiService,
    SwalService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
