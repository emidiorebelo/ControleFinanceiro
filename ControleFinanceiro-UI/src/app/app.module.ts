import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import {TiposService} from './services/tipos.service';
import {CategoriasService} from './services/categorias.service';
import { ListagemCategoriasComponent } from './components/Categoria/listagem-categorias/listagem-categorias.component';

@NgModule({
  declarations: [
    AppComponent,
    ListagemCategoriasComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [
   TiposService,
	 CategoriasService,
   HttpClientModule,
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
