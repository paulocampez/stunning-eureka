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

namespace Stunning.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var teste = GetFuncionarios();
            return View();
        }

        public static List<Funcionarios> GetFuncionarios()
        {
            List<Funcionarios> lstFuncionarios = new List<Funcionarios>();
            string url = "http://localhost:59279/api/Home/";
            HttpWebRequest getRequest = (HttpWebRequest)WebRequest.Create(url);
            getRequest.Method = "GET";
            try
            {
                var getResponse = (HttpWebResponse)getRequest.GetResponse();
                Stream newStream = getResponse.GetResponseStream();
                StreamReader sr = new StreamReader(newStream);
                var result = sr.ReadToEnd();
                lstFuncionarios = JsonConvert.DeserializeObject<List<Funcionarios>>(result);

                return lstFuncionarios;
            }
            catch (Exception ex)
            {
                throw new Exception("erro api");
            }
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
