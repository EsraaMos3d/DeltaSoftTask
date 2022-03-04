using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DeltaSoftTask.Core.Models
{
    public class Task
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Task_Id { get; set; }
        [Required,ForeignKey("Member")]
        public int FK_Member_Id { get; set; }
        // public string MemberName { get; set; }
        [Required, MaxLength(100),MinLength(10)]
        public string Description { get; set; }
        [Required]
        public string deliver_date { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsDeleted { get; set; }
        public virtual Member Member { get; set; }
    }
}
