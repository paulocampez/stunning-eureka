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
        /// <summary>
        /// Transforma uma temperatura em Fahrenheit para o equivalente
        /// nas escalas Celsius e Kelvin.
        /// </summary>
        ///// <param name="temperatura">Temperatura em Fahrenheit</param>
        /// <returns>Objeto contendo valores para uma temperatura
        /// nas escalas Fahrenheit, Celsius e Kelvin.</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public List<Funcionarios> GetTodosFuncionarios()
        {
            var context = new Context(new FileStrategy());
            return context.GetFuncionarios();
        }
        //[Microsoft.AspNetCore.Mvc.HttpGet]
        //public IActionResult Index()
        //{
        //    List<Funcionarios> lstFuncionario = new List<Funcionarios>();
        //    var context = new Context(new FileStrategy());
        //    lstFuncionario = context.GetFuncionarios();
        //    return View(lstFuncionario);
        //}


        //[Microsoft.AspNetCore.Mvc.HttpGet]
        //public IActionResult Privacy()
        //{
        //    return View();
        //}
        //[Microsoft.AspNetCore.Mvc.HttpGet]
        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
