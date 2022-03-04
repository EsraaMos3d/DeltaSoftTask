
export class Member {
      Member_Id :number;
      MemberName :string;
     Email :string;
     Phone :string;
     Address :string;
     IsDeleted :boolean;

    constructor(_Member_Id: number,_MemberName:string,_Email:string, _Phone :string,_Address :string,_IsDeleted:boolean) {
        this.Member_Id = _Member_Id;
        this.MemberName = _MemberName;
        this.Email = _Email;
        this.Phone = _Phone;
        this.Address=_Address;
        this.IsDeleted=_IsDeleted;
}

}
