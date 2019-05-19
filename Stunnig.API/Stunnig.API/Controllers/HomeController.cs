using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stunnig.API.Models;
using Stunnig.API.Models.Strategies;
using Stunnig.API.Models.Strategies.Database;
using Stunnig.Data;
using Stunning.Model;

namespace Stunnig.API.Controllers
{

    [Route("api/Home")]
    [ApiController]
    public class HomeController : Controller
    {
        public StunningContext _context;


        public HomeController(StunningContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retorna Todos os Funcionarios
        /// </summary>
        /// <returns></returns>
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public ActionResult<List<Funcionarios>> Get()
        {

            var context = new Context(new SQLStrategy(_context));
            List<Funcionarios> lstFuncionarios = new List<Funcionarios>();

            lstFuncionarios = context.GetFuncionarios();

            if (lstFuncionarios.Count == 0)
                return NotFound();

            return lstFuncionarios;
        }
        /// <summary>
        /// Retorna Funcionarios Filtrados Por Cargo
        /// </summary>
        /// <param name="cargo"></param>
        /// <returns></returns>
        [Microsoft.AspNetCore.Mvc.HttpGet("BuscaCargo/{cargo}")]
        public ActionResult<List<Funcionarios>> Get(string cargo)
        {
            var context = new Context(new SQLStrategy(_context));
            List<Funcionarios> lstFuncionarios = new List<Funcionarios>();

            lstFuncionarios = context.GetFuncionariosPorCargo(cargo);

            if (lstFuncionarios.Count == 0)
                return NotFound();

            return lstFuncionarios;
        }

        /// <summary>
        /// Insere Funcionario 
        /// <param name="funcionarios"></param>
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public ActionResult<bool> Post([FromBody] Funcionarios funcionarios)
        {
            var context = new Context(new SQLStrategy(_context));
            var success = context.Post(funcionarios);

            return success;
        }
        /// <summary>
        /// Edita Funcionario
        /// </summary>
        /// <param name="id"></param>
        /// <param name="funcionarios"></param>
        /// <returns></returns>
        /// 
        [Microsoft.AspNetCore.Mvc.HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Funcionarios funcionarios)
        {
            var context = new Context(new SQLStrategy(_context));
            var success = context.Put(funcionarios, id);
            return success;
        }
        /// <summary>
        /// Deleta Funcionario
        /// </summary>
        /// <param name="funcionarios"></param>
        /// <returns></returns>
        /// 
        [Microsoft.AspNetCore.Mvc.HttpDelete]
        public void Delete([FromBody] Funcionarios funcionarios)
        {

            //var context = new Context(new FileStrategy());
            var context = new SQLStrategy(_context);
            context.Delete(funcionarios);
        }
        /// <summary>
        /// Deleta Funcionario por CPF
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        /// 
        [Microsoft.AspNetCore.Mvc.HttpDelete("{cpf}")]
        public void Delete(string cpf)
        {
            //var context = new Context(new FileStrategy());
            var context = new SQLStrategy(_context);
            context.DeletePorCpf(cpf);
        }
        /// <summary>
        /// Retorna Funcionarios Filtrados Por CPF
        /// </summary>
        /// <param name="CPF"></param>
        /// <returns></returns>
        [Microsoft.AspNetCore.Mvc.HttpGet("BuscaCPF/{CPF}")]
        public ActionResult<List<Funcionarios>> GetPorCpf(string CPF)
        {
            var context = new Context(new SQLStrategy(_context));
            List<Funcionarios> lstFuncionarios = new List<Funcionarios>();
            lstFuncionarios = context.GetFuncionariosPorCPF(CPF);
            if (lstFuncionarios.Count == 0)
                return NotFound();

            return lstFuncionarios;
        }
        /// <summary>
        /// Retorna Funcionarios Filtrados Por Nome
        /// </summary>
        /// <param name="Nome"></param>
        /// <returns></returns>
        [Microsoft.AspNetCore.Mvc.HttpGet("BuscaNome/{Nome}")]
        public ActionResult<List<Funcionarios>> GetPorNome(string Nome)
        {
            var context = new Context(new SQLStrategy(_context));
            List<Funcionarios> lstFuncionarios = new List<Funcionarios>();
            lstFuncionarios = context.GetFuncionariosPorNome(Nome);
            if (lstFuncionarios.Count == 0)
                return NotFound();

            return lstFuncionarios;
        }
        /// <summary>
        /// Retorna Funcionarios por Range de Data
        /// </summary>
        /// <param name="dataInicio"></param>
        /// <param name="dataFim"></param>
        /// <returns></returns>
        [Microsoft.AspNetCore.Mvc.HttpGet("BuscaData/{dataInicio}/{dataFim}")]
        public ActionResult<List<Funcionarios>> GetPorData(DateTime dataInicio, DateTime dataFim)
        {
            var context = new Context(new SQLStrategy(_context));
            List<Funcionarios> lstFuncionarios = new List<Funcionarios>();
            lstFuncionarios = context.GetFuncionariosPorData(dataInicio, dataFim);

            if (lstFuncionarios.Count == 0)
                return NotFound();

            return lstFuncionarios;
        }
        /// <summary>
        /// Retorna Funcionarios por UF
        /// </summary>
        /// <param name="Uf"></param>
        /// <returns></returns>
        [Microsoft.AspNetCore.Mvc.HttpGet("BuscaUF/{Uf}")]
        public ActionResult<List<Funcionarios>> GetPorUF(string Uf)
        {
            var context = new Context(new SQLStrategy(_context));
            List<Funcionarios> lstFuncionarios = new List<Funcionarios>();
            lstFuncionarios = context.GetFuncionariosAgrupadosPorUF(Uf);
            if (lstFuncionarios.Count == 0)
                return NotFound();

            return lstFuncionarios;
        }
        /// <summary>
        /// Retorna Funcionarios por Range de Salario
        /// </summary>
        /// <param name="salario1"></param>
        /// <param name="salario2"></param>
        /// <returns></returns>
        [Microsoft.AspNetCore.Mvc.HttpGet("BuscaSalario/{salario1}/{salario2}")]
        public ActionResult<List<Funcionarios>> GetPorSalario(double salario1, double salario2)
        {
            var context = new Context(new SQLStrategy(_context));

            List<Funcionarios> lstFuncionarios = new List<Funcionarios>();
            lstFuncionarios = context.GetFuncionariosPorFaixaSalarial(salario1, salario2);
            if (lstFuncionarios.Count == 0)
                return NotFound();

            return lstFuncionarios;
        }
        /// <summary>
        /// Retorna Funcionarios por Status
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        [Microsoft.AspNetCore.Mvc.HttpGet("BuscaStatus/{status}")]
        public ActionResult<List<Funcionarios>> GetPorStatus(string status)
        {
            var context = new Context(new SQLStrategy(_context));
            List<Funcionarios> lstFuncionarios = new List<Funcionarios>();
            lstFuncionarios = context.GetFuncionariosPorStatus(status);

            if (lstFuncionarios.Count == 0)
                return NotFound();

            return lstFuncionarios;
        }


    }
}
