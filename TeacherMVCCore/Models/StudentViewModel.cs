using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherMVCCore.Models
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string TeacherName { get; set; }
        public int? TeacherId { get; set; }
    }
}
