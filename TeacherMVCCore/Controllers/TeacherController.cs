using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeacherMVCCore.Models;

namespace TeacherMVCCore.Controllers
{
    public class TeacherController : Controller
    {
        private readonly TeacherContext _teacherContext;
        public List<StudentInfo> studentInfos = new List<StudentInfo>();
        //public List<StudentViewModel> studentViewModels = new List<StudentViewModel>();
        public TeacherController(TeacherContext teacherContext)
        {
            _teacherContext = teacherContext;
        }
        public IActionResult Index(TeacherViewModel teacherViewModel)
        {
            try
            {
                // studentInfos=_teacherContext.StudentInfos.Where(s => s.TeacherId == teacherViewModel.TeacherId).ToList();
                List<StudentViewModel> studentViewModels = (from students in _teacherContext.StudentInfos
                          join teacherDetails in _teacherContext.TeacherInfos on students.TeacherId equals teacherDetails.TeacherId
                          where students.TeacherId == teacherViewModel.TeacherId
                          select new StudentViewModel
                          {
                              StudentId= students.StudentId,
                              StudentName= students.StudentName,
                              TeacherName= teacherDetails.TeacherName
                          }).ToList();

                return View(studentViewModels);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
