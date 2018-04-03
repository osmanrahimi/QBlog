import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';

import { PostListComponent } from './post-list/post-list.component';
import { HomeLayoutComponent } from './layouts/home-layout/home-layout.component';
import { DetailsLayoutComponent } from './layouts/details-layout/details-layout.component';
import { PostDetailsComponent } from './post-details/post-details.component';
import { PostService } from './services/post.service';
import { HttpClientModule } from '@angular/common/http';


@NgModule({
  declarations: [
    AppComponent,
    PostListComponent,
    HomeLayoutComponent,
    DetailsLayoutComponent,
    PostDetailsComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
 
  ],
  providers: [PostService],
  bootstrap: [AppComponent],
 
})
export class AppModule { }
