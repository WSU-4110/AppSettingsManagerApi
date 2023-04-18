import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { HttpHeadersInterceptor } from './services/bff/common/http-headers.interceptor';
import { MatTableModule } from '@angular/material/table';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatDialogModule } from '@angular/material/dialog';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { HomeComponent } from './home/home.component';
import { SettingsService } from './services/bff/settings.service';
import { UserService } from './services/bff/users.service';
import { ViewSettingsComponent } from './home/view-settings/view-settings.component';
import { CreateSettingGroupComponent } from './home/create-setting-group/create-setting-group.component';
import { UpdateSettingComponent } from './home/view-settings/update-setting/update-setting.component';
import { HeaderComponent } from './header/header.component';
import { ViewPermissionsComponent } from './home/view-permissions/view-permissions.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    HomeComponent,
    ViewSettingsComponent,
    CreateSettingGroupComponent,
    UpdateSettingComponent,
    HeaderComponent,
    ViewPermissionsComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    MatButtonModule,
    MatFormFieldModule,
    MatInputModule,
    MatTableModule,
    MatDialogModule
  ],
  providers: [
    // BffService,
    // { provide: 'baseURL', useValue: 'https://appsettingsmanagerbff.azurewebsites.net/'}
    SettingsService,
    UserService,
    {
      provide: HTTP_INTERCEPTORS,
      useClass: HttpHeadersInterceptor,
      multi: true,
    },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
