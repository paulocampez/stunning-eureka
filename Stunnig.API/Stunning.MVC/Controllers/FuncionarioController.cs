using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Stunning.Model;

namespace Stunning.MVC.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            List<Funcionarios> listaFuncionarios = new List<Funcionarios>();

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

                return View(lstFuncionarios.ToList());
            }
            catch (Exception ex)
            {
                throw new Exception("erro api");
            }
            return View(listaFuncionarios);

        }

        // GET: Funcionario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Funcionario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Funcionario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            DateTime dateCad = new DateTime();
            decimal salario = new decimal();
            Funcionarios funcionario = new Funcionarios();
            funcionario.Cargo = collection["Cargo"].ToString();
            funcionario.Status = collection["Status"].ToString();
            funcionario.Cpf = collection["Cpf"].ToString();
            if (DateTime.TryParse(collection["DataCad"].ToString(), out dateCad))
                funcionario.DataCad = dateCad;
            else
                funcionario.DataCad = DateTime.MinValue;

            funcionario.Nome = collection["Nome"].ToString();
            funcionario.IdFuncionario = int.Parse(collection["IdFuncionario"]);
            if (decimal.TryParse(collection["Salario"].ToString(), out salario))
                funcionario.Salario = salario;
            else
                funcionario.Salario = salario;
            funcionario.UfNasc = collection["UfNasc"].ToString();
            //TODO: Jogar para BLL
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:59279/api/Home");

                    //HTTP POST
                    var postTask = client.PostAsJsonAsync<Funcionarios>("Home", funcionario);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }

                ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Funcionario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Funcionario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Funcionario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Funcionario/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}