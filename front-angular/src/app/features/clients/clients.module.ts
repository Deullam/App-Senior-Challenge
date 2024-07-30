import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';

import { AppMaterialModule } from '../../shared/app-material/app-material.module';
import { ClientsRoutingModule } from './clients-routing.module';





@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    ClientsRoutingModule,
    AppMaterialModule,
  ]
})
export class ClientsModule { }
