import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { FormBuilder, FormGroup, FormArray } from '@angular/forms';
import { AppMaterialModule } from '../../../../shared/app-material/app-material.module';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-client-dialog',
  templateUrl: './client-dialog.component.html',
  styleUrls: ['./client-dialog.component.scss'],
  imports: [AppMaterialModule, CommonModule],
  standalone: true
})
export class ClientDialogComponent {

  clientForm: FormGroup;

  constructor(
    public dialogRef: MatDialogRef<ClientDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private fb: FormBuilder
  ) {
    this.clientForm = this.fb.group({
      id: [data?.id || null],
      name: [data?.name || ''],
      // emails: this.fb.array(data?.emails || []),
      // phones: this.fb.array(data?.phones || [])
    });
  }

  get emails(): FormArray {
    return this.clientForm.get('emails') as FormArray;
  }

  get phones(): FormArray {
    return this.clientForm.get('phones') as FormArray;
  }

  addEmail(): void {
    this.emails.push(this.fb.control(''));
  }

  removeEmail(index: number): void {
    this.emails.removeAt(index);
  }

  addPhone(): void {
    this.phones.push(this.fb.control(''));
  }

  removePhone(index: number): void {
    this.phones.removeAt(index);
  }

  onSave(): void {
    this.dialogRef.close(this.clientForm.value);
  }

  onCancel(): void {
    this.dialogRef.close();
  }
}
