using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeacherMVCCore.Models;

namespace TeacherMVCCore.Controllers
{
    public class TeacherInformationController : Controller
    {
        private readonly TeacherContext _teacherContext;
        public TeacherInfo teacherInfo = new TeacherInfo();
        public TeacherInformationController(TeacherContext teacherContext)
        {
            _teacherContext = teacherContext;
        }
        public IActionResult Index(string id)
        {
            try
            {
                teacherInfo = _teacherContext.TeacherInfos.Where(t => t.TeacherName == id).FirstOrDefault();
                return View(teacherInfo);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
