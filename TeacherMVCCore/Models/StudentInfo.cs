using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherMVCCore.Models
{
    public class StudentInfo
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Grade { get; set; }
        public int? TeacherId { get; set; }
    }
}
