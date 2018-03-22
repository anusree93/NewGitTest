using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
using System.Data.Entity;
namespace Electronica.Entity
{
    [Table("Enrollment")]
    public class Enrollment
    {
        [Key]
        [Column(Order = 1)]
        public int EnrollmentId { get; set; }
        [Column(Order = 2)]
        [ForeignKey("EventId")]
        public int EnrollmentEventId { get; set; }
        public Event EventId { get; set; } 

        [Column(Order = 3)]
        [ForeignKey("MemberId")]
        public int EnrollmentMemberId { get; set; }
        public Member MemberId { get; set; }
        
        [Column(Order =4)]
        [DefaultValue("false")]
        public Boolean PaymentStatus { get; set; }
        [Column(Order =5)]
        public int PresentationSkill { get; set; }
        [Column(Order = 6)]
        public int SubjectKnowledge{ get; set; }
        [Column(Order = 7)]
        public int TrainingSkill { get; set; }
        [Column(Order = 8)]
        public int TrainingContent { get; set; }
        [Column(Order = 9)]
        public int InteractionSkill { get; set; }
        [Column(Order =10)]
        public string Comments { get; set; }
    }
}
