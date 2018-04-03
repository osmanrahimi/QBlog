import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeLayoutComponent } from './layouts/home-layout/home-layout.component';
import { DetailsLayoutComponent } from './layouts/details-layout/details-layout.component';
import { PostDetailsComponent } from './post-details/post-details.component';

const routes: Routes = [
  {path:'',redirectTo:'home',pathMatch:'full'},
  {

    path: 'home', component: HomeLayoutComponent,
    children:[]
  },
  {
    path:'posts', component: DetailsLayoutComponent,
    children: [
      {path:'show/:id',component:PostDetailsComponent}
        ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
