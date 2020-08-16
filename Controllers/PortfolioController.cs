using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using portfolio.Models;

namespace portfolio.Controllers
{
    public class portfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
