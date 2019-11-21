using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cosmetic.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cosmetic.Controllers
{
    public class TinTuc : Controller
    {
        [Route("[controller]/[action]")]
        public IActionResult Index()
        {
            return View("TinTuc");
        }
    }
}