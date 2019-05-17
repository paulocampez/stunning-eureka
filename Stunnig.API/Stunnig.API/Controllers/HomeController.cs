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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CPF"></param>
        /// <returns></returns>
        [Microsoft.AspNetCore.Mvc.HttpGet("BuscaCPF/{CPF}")]
        public List<Funcionarios> GetPorCpf(string CPF)
        {
            var context = new Context(new FileStrategy());
            return context.GetFuncionariosPorCPF(CPF);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Nome"></param>
        /// <returns></returns>
        [Microsoft.AspNetCore.Mvc.HttpGet("BuscaNome/{Nome}")]
        public List<Funcionarios> GetPorNome(string Nome)
        {
            var context = new Context(new FileStrategy());
            return context.GetFuncionariosPorNome(Nome);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataInicio"></param>
        /// <param name="dataFim"></param>
        /// <returns></returns>
        [Microsoft.AspNetCore.Mvc.HttpGet("BuscaData/{dataInicio}/{dataFim}")]
        public List<Funcionarios> GetPorData(DateTime dataInicio, DateTime dataFim)
        {
            var context = new Context(new FileStrategy());
            return context.GetFuncionariosPorData(dataInicio,dataFim);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Uf"></param>
        /// <returns></returns>
        [Microsoft.AspNetCore.Mvc.HttpGet("BuscaUF/{Uf}")]
        public List<Funcionarios> GetPorUF(string Uf)
        {
            var context = new Context(new FileStrategy());
            return context.GetFuncionariosAgrupadosPorUF(Uf);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="salario1"></param>
        /// <param name="salario2"></param>
        /// <returns></returns>
        [Microsoft.AspNetCore.Mvc.HttpGet("BuscaSalario/{salario1}/{salario2}")]
        public List<Funcionarios> GetPorSalario(decimal salario1, decimal salario2)
        {
            var context = new Context(new FileStrategy());
            return context.GetFuncionariosPorFaixaSalarial(salario1, salario2);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        [Microsoft.AspNetCore.Mvc.HttpGet("BuscaStatus/{status}")]
        public List<Funcionarios> GetPorStatus(string status)
        {
            var context = new Context(new FileStrategy());
            return context.GetFuncionariosPorStatus(status);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="funcionarios"></param>
        /// <returns></returns>
        /// 
        [Microsoft.AspNetCore.Mvc.HttpDelete]
        public void Delete([FromBody] Funcionarios funcionarios)
        {
            var context = new Context(new FileStrategy());
            context.Delete(funcionarios);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 
        [Microsoft.AspNetCore.Mvc.HttpPut("{id}")]
        public void Put(int id, [FromBody] Funcionarios funcionarios)
        {
            var teste = id;
            var context = new Context(new FileStrategy());
            context.Put(funcionarios);
        }
    }
}
