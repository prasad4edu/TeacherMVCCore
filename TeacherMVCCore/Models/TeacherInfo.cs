using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherMVCCore.Models
{
    public class TeacherInfo
    {
        [Key]
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
    }
}
