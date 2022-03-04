import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, tap } from 'rxjs';
import { Task } from './Task';

@Injectable({
  providedIn: 'root'
})
export class TaskService {
  //  task :Task=new Task(0,0,"",false);
  //  tasks: any;
  //  taskstring: string = '';
  url:string='https://localhost:44384/api/';
  constructor(private http: HttpClient) {
    this.GetMembers();
  }
  GetMembers() {
    return this.http.get(this.url+"Member/getall");
  }
  GetTasks() {
    return this.http.get(this.url+"Task/getall");
  }
  Save(task:Task) {
    return this.http.post<Task>(this.url+"Task/AddTask", task);
  }
  CheckCompleted(Id:number,item:Task)
  {
    return this.http.post(this.url+"Task/EditTask", item);
  }
}
