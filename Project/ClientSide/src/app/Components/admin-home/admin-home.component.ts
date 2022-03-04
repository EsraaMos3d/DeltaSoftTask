import { getLocaleDateTimeFormat } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Form } from '@angular/forms';
import { Member } from 'src/app/shared/member';
import { Task } from 'src/app/shared/Task';
import { TaskService } from 'src/app/shared/Task.service';

@Component({
  selector: 'app-admin-home',
  templateUrl: './admin-home.component.html',
  styleUrls: ['./admin-home.component.css']
})
export class AdminHomeComponent implements OnInit {
  date: string = new Date().toString();
  tasks: any = [];
  members: any = [];
  task: Task = new Task(0, 0, "", "", false, false, null);
  keyword = 'memberName';
  constructor(private taskService: TaskService) { }

  ngOnInit() {
    this.GetAllMembers();
    this.GetAllTasks();
  }
  GetAllMembers() {
    this.taskService.GetMembers().subscribe(res => {
      this.members = JSON.parse(JSON.stringify(res));
    })
  }
  GetAllTasks() {
    this.taskService.GetTasks().subscribe(res => {
      this.tasks = JSON.parse(JSON.stringify(res));
    })

  }
  onSubmit(AddTask: any) {
    this.taskService.Save(this.task).subscribe(res => {
      this.tasks = JSON.parse(JSON.stringify(res));
      AddTask.reset();
    })
  }
  onCheckboxChange(item: Task, e: any) {

    if (e.target.checked) {
      item.IsCompleted = true;
      this.taskService.CheckCompleted(item.Task_Id, item).subscribe(res => {
        this.tasks = JSON.parse(JSON.stringify(res));
      });
    }
  }
  selectEvent(item: any) {
    this.task.FK_Member_Id = item.member_Id;

  }

  onChangeSearch(val: string) {

    this.members.some((elem: any) => {
      if (!(elem.memberName.toString().toLowerCase() === val.toLowerCase())) {
        this.task.FK_Member_Id = 0;
      }
      else {
        this.task.FK_Member_Id = elem.member_Id;
        throw true;
      }
    });
  }


}

