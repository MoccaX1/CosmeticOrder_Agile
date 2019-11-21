using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cosmetic.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cosmetic.Controllers
{
    public class AdminController : Controller
    {
        [Route("[controller]/[action]")]
        public IActionResult Index()
        {
            return View();
        }
        private readonly MyPhamContext db;
        public AdminController(MyPhamContext context)
        {
            db = context;
        }
        [Route("[controller]/[action]")]
        public IActionResult Login()
        {
            return View();
        }
    }
}