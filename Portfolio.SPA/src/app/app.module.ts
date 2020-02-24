import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { MDBBootstrapModule } from 'angular-bootstrap-md';
import { HttpClientModule } from '@angular/common/http';


import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { BlogComponent } from './blog/blog.component';
import { ProjectComponent } from './project/project.component';
import { ContactComponent } from './contact/contact.component';



const routes: Routes = [
  { path: 'home', component: HomeComponent  },
  { path: 'about', component: AboutComponent  },
  { path: 'blog', component: BlogComponent},
  { path: 'project', component: ProjectComponent},
  { path: 'contact', component: ContactComponent}
];

@NgModule({
   declarations: [
      AppComponent,
      HomeComponent,
      AboutComponent,
      BlogComponent,
      ProjectComponent,
      ContactComponent
   ],
   imports: [
      BrowserModule,
      MDBBootstrapModule.forRoot(),
      RouterModule.forRoot(routes),
      HttpClientModule
   ],
   providers: [],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
