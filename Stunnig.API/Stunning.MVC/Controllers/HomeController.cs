using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stunning.MVC.Models;
using Stunning.Model;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace Stunning.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Funcionarios funcionario = new Funcionarios();
            //funcionario.Cargo = "Dev";
            //funcionario.Status = "ATIVO";
            //funcionario.Cpf = "32696114803";
            //funcionario.DataCad = DateTime.Now;
            //funcionario.Nome = "Paulo";
            //funcionario.IdFuncionario = 2;
            //funcionario.Salario = 3000M;
            //funcionario.UfNasc = "SP";


            //var teste = Teste(funcionario);
            return View();
        }

        //public static List<Funcionarios> GetFuncionarios()
        //{
        //    List<Funcionarios> lstFuncionarios = new List<Funcionarios>();
        //    string url = "http://localhost:59279/api/Home/";
        //    HttpWebRequest getRequest = (HttpWebRequest)WebRequest.Create(url);
        //    getRequest.Method = "GET";
        //    try
        //    {
        //        var getResponse = (HttpWebResponse)getRequest.GetResponse();
        //        Stream newStream = getResponse.GetResponseStream();
        //        StreamReader sr = new StreamReader(newStream);
        //        var result = sr.ReadToEnd();
        //        lstFuncionarios = JsonConvert.DeserializeObject<List<Funcionarios>>(result);

        //        return lstFuncionarios;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("erro api");
        //    }
        //}

        //[HttpPost]
        //public IActionResult Teste([FromBody] Funcionarios person)
        //{
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri("http://localhost:59279/api/Home");

        //        //HTTP POST
        //        var postTask = client.PostAsJsonAsync<Funcionarios>("Home", person);
        //        postTask.Wait();

        //        var result = postTask.Result;
        //        if (result.IsSuccessStatusCode)
        //        {
        //            return RedirectToAction("Index");
        //        }
        //    }

        //    ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

           
        //    return Json(person);
        //}



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
