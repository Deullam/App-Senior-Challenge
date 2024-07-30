import { animate, state, style, transition, trigger } from '@angular/animations';
import { CommonModule } from '@angular/common';
import { Component, Inject } from '@angular/core';
import { FormArray, FormBuilder, FormGroup } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';

import { MatDialog } from '@angular/material/dialog';
import { ClientDialogComponent } from './client-dialog/client-dialog.component';


import { AppMaterialModule } from '../../../shared/app-material/app-material.module';
import { Client } from '../models/client';
import { ClientsService } from '../services/clients.service';
import { BehaviorSubject, catchError, combineLatest, Observable, of, pipe } from 'rxjs';
import { map } from 'rxjs/operators';


@Component({
  selector: 'app-clients',
  standalone: true,
  imports: [
    CommonModule,
    AppMaterialModule,
    MatButtonModule,
  ],
  templateUrl: './clients.component.html',
  styleUrl: './clients.component.scss',
  providers: [ClientsService],
  animations: [
    trigger('detailExpand', [
      state('collapsed,void', style({ height: '0px', minHeight: '0' })),
      state('expanded', style({ height: '*' })),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})

export class ClientsComponent {
  dataSource$: Observable<any[]>;

  constructor(public dialog: MatDialog, private clientsService: ClientsService) {
    this.clients = this.clientsService.getClients()
      .pipe(catchError(error => {
        return of([])
      }));
    this.dataSource$ = this.clientsService.getClients();

  }

  // Filtro da tabela
  // filterSubject = new BehaviorSubject<string>('');
  // applyFilter(event: Event): void {
  //   const filterValue = (event.target as HTMLInputElement).value.trim().toLowerCase();
  //   this.filterSubject.next(filterValue);
  // }
  //dataSource2 = new MatTableDataSource(CLIENTS_DATA);
  clients: Observable<Client[]>;
  columnsToDisplay = [
    'name',
    'created_at',
    'actions'
  ];
  columnsToDisplayWithExpand = [...this.columnsToDisplay, 'expand'];
  expandedElement: Client | any[] = [];

  openDialog(client: any = null): void {
    const dialogRef = this.dialog.open(ClientDialogComponent, {
      width: '600px',
      data: client
    });

    // dialogRef.afterClosed().subscribe(result => {
    //   if (result) {
    //     if (client) {
    //       // Update existing client
    //       const index = this.dataSource.findIndex(c => c.id === client.id);
    //       this.dataSource[index] = result;
    //       this.updateClient(result);
    //     } else {
    //       // Add new client
    //       result.id = this.dataSource.length + 1;
    //       this.dataSource.push(result);
    //       this.addClient(result);
    //     }
    //     this.dataSource = [...this.dataSource];
    //   }
    // });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        if (client) {
          // Update existing client
          this.clientsService.updateClient(result).subscribe();
        } else {
          // Add new client
          this.clientsService.addClient(result).subscribe();
        }
      }
    });
  }

  // deleteClient(client: any): void {
  //   const index = this.dataSource.findIndex(c => c.id === client.id);
  //   if (index >= 0) {
  //     this.dataSource.splice(index, 1);
  //     this.dataSource = [...this.dataSource];
  //     // this.clientsService.deleteClient(client.id).subscribe();
  //   }
  // }
  deleteClient(client: any): void {
    this.clientsService.deleteClient(client.id).subscribe();
  }

  addClient(client: any): void {
    // this.clientsService.addClient(client).subscribe();
  }

  updateClient(client: any): void {
    // this.clientsService.updateClient(client).subscribe();
  }

}





// const CLIENTS_DATA: Client[] = [
//   {
//     id: 1,
//     name: 'João Silva',
//     emails: ['joao.silva@example.com', 'joao@example.com', 'joao@example.com', 'joao@example.com', 'joao@example.com', 'joao@example.com', 'joao@example.com', 'joao@example.com'],
//     phones: ['(11) 1234-5678', '(11) 8765-4321'],
//     created_at: new Date('2023-01-01'),
//   },
//   {
//     id: 2,
//     name: 'Maria Oliveira',
//     emails: ['maria.oliveira@example.com'],
//     phones: ['(21) 9876-5432'],
//     created_at: new Date('2023-02-15')
//   },
//   {
//     id: 3,
//     name: 'Carlos Pereira',
//     emails: ['carlos.pereira@example.com', 'c.pereira@example.com'],
//     phones: ['(31) 9988-7766', '(31) 8877-6655'],
//     created_at: new Date('2023-03-10')
//   },
//   {
//     id: 4,
//     name: 'Ana Souza',
//     emails: ['ana.souza@example.com'],
//     phones: ['(41) 9999-8888'],
//     created_at: new Date('2023-04-25')
//   },
//   {
//     id: 5,
//     name: 'Pedro Lima',
//     emails: ['pedro.lima@example.com', 'p.lima@example.com'],
//     phones: ['(51) 9123-4567', '(51) 7654-3210'],
//     created_at: new Date('2023-05-30')
//   }
// ];
