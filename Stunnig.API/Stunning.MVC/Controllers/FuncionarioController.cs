using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
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
            return View(GetFuncionario());
        }

        // GET: Funcionario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public List<Funcionarios> GetFuncionario()
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
            Funcionarios funcionarios = new Funcionarios();
            funcionarios = GetFuncionario().Where(p => p.IdFuncionario == id).FirstOrDefault();
            return View(funcionarios);
        }

        // POST: Funcionario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
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

                try
                {
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("http://localhost:59279/api/" + id);

                        //HTTP POST
                        var postTask = client.PutAsJsonAsync<Funcionarios>("Home/"+id, funcionario);
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


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Funcionario/Delete/5
        public ActionResult Delete(string Nome)
        {
            Funcionarios funcionario = new Funcionarios();
            funcionario = GetFuncionario().FirstOrDefault(p => p.Nome == Nome);

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:59279/api/Home");

                    //HTTP DELETE
                    var request = new HttpRequestMessage
                    {
                        Method = HttpMethod.Delete,
                        RequestUri = new Uri("http://localhost:59279/api/Home"),
                        Content = new StringContent(JsonConvert.SerializeObject(funcionario), Encoding.UTF8, "application/json")
                    };
                    var response = client.SendAsync(request);
                    response.Wait();

                    var result = response.Result;
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