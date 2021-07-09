using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TeacherMVCCore.Models;

namespace TeacherMVCCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TeacherContext _teacherContext;
        //public List<TeacherInfo> teacherInfos = new List<TeacherInfo>();
        public TeacherViewModel teacherViewModel = new TeacherViewModel();
        public HomeController(ILogger<HomeController> logger,TeacherContext teacherContext)
        {
            _logger = logger;
            _teacherContext = teacherContext;
        }

        public IActionResult Index()
        {
            try
            {
                teacherViewModel.teacherInfos = _teacherContext.TeacherInfos.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View(teacherViewModel);
        }
       

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
