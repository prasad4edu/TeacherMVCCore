using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherMVCCore.Models
{
    public class TeacherViewModel
    {
        public int TeacherId { get; set; }
        public List<TeacherInfo> teacherInfos { get; set; }
    }
}
