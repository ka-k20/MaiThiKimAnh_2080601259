using MaiThiKimAnh_2080601259.Models;
using MaiThiKimAnh_2080601259.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaiThiKimAnh_2080601259.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Create()
        {
            var viewmodel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewmodel);
        }
    }
}