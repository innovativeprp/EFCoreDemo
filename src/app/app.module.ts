//Modules
import { NgModule } from '@angular/core'
import { SharedRootModules } from './shared/shared-modules'

//Components
import { SharedRootComponents } from './shared/shared-components'
import { AppComponent } from './app.component'

@NgModule({
  declarations: [SharedRootComponents],
  imports: [SharedRootModules],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
