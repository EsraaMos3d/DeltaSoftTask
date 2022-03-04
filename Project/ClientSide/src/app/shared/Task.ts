import { Member } from "./member";

export class Task {
    Task_Id :number;
    FK_Member_Id :number;
    Description :string;
    deliver_date:string;
    IsCompleted:boolean;
    IsDeleted:boolean;
    Member?:any;
    constructor(_Task_Id: number,_FK_Member_Id:number, _Description :string,_deliver_date :string,_IsCompleted:boolean,_IsDeleted:boolean,_Member:any) {
        this.Task_Id = _Task_Id;
        this.FK_Member_Id = _FK_Member_Id;
        this.Description = _Description;
        this.IsCompleted = _IsCompleted;
        this.deliver_date=_deliver_date;
        this.IsDeleted=_IsDeleted;
        this.Member=_Member;
}
}
