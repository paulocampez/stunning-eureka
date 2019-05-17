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
        /// 
        /// </summary>
        /// <returns></returns>
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public List<Funcionarios> Get()
        {
            var context = new Context(new FileStrategy());
            return context.GetFuncionarios();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cargo"></param>
        /// <returns></returns>
        [Microsoft.AspNetCore.Mvc.HttpGet("BuscaCargo/{cargo}")]
        public List<Funcionarios> Get(string cargo)
        {
            var context = new Context(new FileStrategy());
            return context.GetFuncionariosPorCargo(cargo);
        }

        /// <summary>
        /// 
        /// 
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public void Post([FromBody] Funcionarios funcionarios)
        {
            var context = new Context(new FileStrategy());
            context.Post(funcionarios);
        }




        //[Microsoft.AspNetCore.Mvc.HttpGet("Post/{nome}")]
        //public void Post([FromBody] string nome)
        //{
        //    Funcionarios funcionario = new Funcionarios();
        //    var context = new Context(new FileStrategy());
        //    context.Post(funcionario);
        //}
    }
}
