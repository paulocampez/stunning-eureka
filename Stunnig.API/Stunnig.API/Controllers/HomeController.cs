using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stunnig.API.Models;
using Stunnig.API.Models.Strategies;
using Stunnig.API.Models.Strategies.Database;
using Stunning.Model;

namespace Stunnig.API.Controllers
{
    [Route("api/Home")]
    [ApiController]
    public class HomeController : Controller
    {

        // GET: api/<controller>
        [HttpGet]
        public List<Funcionarios> GetTodosFuncionarios()
        {
            var context = new Context(new FileStrategy());
            return context.GetFuncionarios();
        }
        
        public IActionResult Index()
        {
            List<Funcionarios> lstFuncionario = new List<Funcionarios>();
            var context = new Context(new FileStrategy());
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
