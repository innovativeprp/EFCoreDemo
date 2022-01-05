import { Component, OnInit } from '@angular/core'

@Component({
  selector: 'app-create-post',
  templateUrl: 'post-create.component.html',
  styleUrls: ['post-create.component.css'],
})
export class PostCreateComponent implements OnInit {
  message: string = 'hello'
  constructor() {}

  ngOnInit() {}
  postMessage() {
    console.log(this.message)
  }
}
