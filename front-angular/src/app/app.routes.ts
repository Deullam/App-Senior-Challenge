import { Routes } from '@angular/router';

export const routes: Routes = [
  { path: '', pathMatch: 'full', redirectTo: 'clients' },
  {
    path: 'clients',
    loadChildren: () => import('./features/clients/clients.module').then(m => m.ClientsModule)
  },

];
