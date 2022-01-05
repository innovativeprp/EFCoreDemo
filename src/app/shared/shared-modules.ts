import { FormsModule } from '@angular/forms'
import { BrowserModule } from '@angular/platform-browser'
import { BrowserAnimationsModule } from '@angular/platform-browser/animations'
import { MaterialModule } from './material.module'

export const SharedRootModules = [
  BrowserModule,
  BrowserAnimationsModule,
  FormsModule,
  MaterialModule,
]
