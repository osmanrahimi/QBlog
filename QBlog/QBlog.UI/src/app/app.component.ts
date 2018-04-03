import { Component } from '@angular/core';
import { OnInit } from '@angular/core/src/metadata/lifecycle_hooks';
import { PostService } from './services/post.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],

})
export class AppComponent implements OnInit{
  title = 'app';

  constructor(private postService: PostService) {

  }

  ngOnInit():void {
    console.log('this is in onInit');
    this.postService.getProducts();
  }
}
