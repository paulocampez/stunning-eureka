using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stunnig.API.Models;
using Stunnig.API.Models.Strategies;
using Stunnig.API.Models.Strategies.Database;
using static Stunnig.API.Models.DDD;

namespace Stunnig.API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Funcionario> lstFuncionario = new List<Funcionario>();

            var context = new Base(new FileStrategy());
            lstFuncionario = context.GetFuncionarios();
            return View(lstFuncionario);
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
