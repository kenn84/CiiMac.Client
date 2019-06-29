using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CiiMac.MVC.Models;
using CiiMac.MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace CiiMac.MVC.Controllers
{
    public class ValueController : Controller
    {
        public IActionResult Index()
        {
            
           Task<Values> values = ValueService.GetValuesAsync("https://localhost:44311/api/values");
            return View();
        }
    }
}