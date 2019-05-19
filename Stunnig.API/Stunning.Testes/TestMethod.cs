using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using Stunnig.API;
using Stunnig.API.Controllers;
using Stunnig.Data;
using Stunning.Model;
using Stunning.MVC;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Tests
{
    public class Tests
    {
        public StunningContext _context;
        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<StunningContext>()
.UseInMemoryDatabase(databaseName: "TesteFuncionario")
.Options;
            List<Funcionarios> lista = new List<Funcionarios>();
            using (var context = new StunningContext(options))
            {
                context.Funcionarios.Add(
                    new Funcionarios
                    {
                        DataCad = DateTime.Parse("16/04/2017"),
                        Cargo = "Analista Jr",
                        Cpf = "41851452257",
                        Nome = "Ada Aanderud",
                        UfNasc = "ES",
                        Salario = 1355.10,
                        Status = "ATIVO"
                    }
                    );
                context.SaveChanges();

            }

        }
        #region NotFound
        [Test]
        public void CpfInexistente()
        {
            var options = new DbContextOptionsBuilder<StunningContext>()
.UseInMemoryDatabase(databaseName: "TesteFuncionario")
.Options;
            List<Funcionarios> lista = new List<Funcionarios>();
            using (var context = new StunningContext(options))
            {
                HomeController homeController = new HomeController(context);
                var responseFuncionario = homeController.GetPorCpf("CPFQUENAOEXISTE");
                var result = responseFuncionario.Result as StatusCodeResult;
                Assert.AreEqual(result.StatusCode, (int)HttpStatusCode.NotFound);

            }
        }
        [Test]
        public void CargoInexistente()
        {
            var options = new DbContextOptionsBuilder<StunningContext>()
        .UseInMemoryDatabase(databaseName: "TesteFuncionario")
        .Options;
            List<Funcionarios> lista = new List<Funcionarios>();
            using (var context = new StunningContext(options))
            {
                HomeController homeController = new HomeController(context);
                var responseFuncionario = homeController.Get("Cargoquenaoexiste");
                var result = responseFuncionario.Result as StatusCodeResult;
                Assert.AreEqual(result.StatusCode, (int)HttpStatusCode.NotFound);
            }
        }
        [Test]
        public void NomeInexistente()
        {
            var options = new DbContextOptionsBuilder<StunningContext>()
        .UseInMemoryDatabase(databaseName: "TesteFuncionario")
        .Options;
            List<Funcionarios> lista = new List<Funcionarios>();
            using (var context = new StunningContext(options))
            {
                HomeController homeController = new HomeController(context);
                var responseFuncionario = homeController.GetPorNome("Nomequenaoexiste");
                var result = responseFuncionario.Result as StatusCodeResult;
                Assert.AreEqual(result.StatusCode, (int)HttpStatusCode.NotFound);
            }
        }
        [Test]
        public void DataInexistente()
        {
            var options = new DbContextOptionsBuilder<StunningContext>()
        .UseInMemoryDatabase(databaseName: "TesteFuncionario")
        .Options;
            List<Funcionarios> lista = new List<Funcionarios>();
            using (var context = new StunningContext(options))
            {
                HomeController homeController = new HomeController(context);
                var responseFuncionario = homeController.GetPorData(DateTime.Now, DateTime.Now);
                var result = responseFuncionario.Result as StatusCodeResult;
                Assert.AreEqual(result.StatusCode, (int)HttpStatusCode.NotFound);
            }
        }
        [Test]
        public void UFInexistente()
        {
            var options = new DbContextOptionsBuilder<StunningContext>()
        .UseInMemoryDatabase(databaseName: "TesteFuncionario")
        .Options;
            List<Funcionarios> lista = new List<Funcionarios>();
            using (var context = new StunningContext(options))
            {
                HomeController homeController = new HomeController(context);
                var responseFuncionario = homeController.GetPorUF("TT");
                var result = responseFuncionario.Result as StatusCodeResult;
                Assert.AreEqual(result.StatusCode, (int)HttpStatusCode.NotFound);
            }
        }
        [Test]
        public void SalarioInexistente()
        {
            var options = new DbContextOptionsBuilder<StunningContext>()
        .UseInMemoryDatabase(databaseName: "TesteFuncionario")
        .Options;
            List<Funcionarios> lista = new List<Funcionarios>();
            using (var context = new StunningContext(options))
            {
                HomeController homeController = new HomeController(context);
                var responseFuncionario = homeController.GetPorSalario(111111111.1, 111111111.2);
                var result = responseFuncionario.Result as StatusCodeResult;
                Assert.AreEqual(result.StatusCode, (int)HttpStatusCode.NotFound);
            }
        }
        [Test]
        public void StatusInexistente()
        {
            var options = new DbContextOptionsBuilder<StunningContext>()
        .UseInMemoryDatabase(databaseName: "TesteFuncionario")
        .Options;
            List<Funcionarios> lista = new List<Funcionarios>();
            using (var context = new StunningContext(options))
            {
                HomeController homeController = new HomeController(context);
                var responseFuncionario = homeController.GetPorStatus("STATUSQUENAOEXISTE");
                var result = responseFuncionario.Result as StatusCodeResult;
                Assert.AreEqual(result.StatusCode, (int)HttpStatusCode.NotFound);
            }
        }
        #endregion
        [Test]
        public void GetSuccess()
        {
            var options = new DbContextOptionsBuilder<StunningContext>()
    .UseInMemoryDatabase(databaseName: "TesteFuncionario")
    .Options;
            using (var context = new StunningContext(options))
            {
                HomeController homeController = new HomeController(context);
                var responseFuncionario = homeController.Get();

                Assert.IsNotNull(responseFuncionario);
                Assert.IsNotNull(responseFuncionario.Value);
                Assert.IsNotNull(responseFuncionario.Value.Count > 0);
            }

        }
        [Test]
        public void CargoExistente()
        {
            var options = new DbContextOptionsBuilder<StunningContext>()
    .UseInMemoryDatabase(databaseName: "TesteFuncionario")
    .Options;
            using (var context = new StunningContext(options))
            {
                HomeController homeController = new HomeController(context);
                var responseFuncionario = homeController.Get("Analista Jr");

                Assert.IsNotNull(responseFuncionario);
                Assert.IsNotNull(responseFuncionario.Value);
                Assert.IsNotNull(responseFuncionario.Value.Count > 0);
            }

        }
        [Test]
        public void NomeExistente()
        {
            var options = new DbContextOptionsBuilder<StunningContext>()
    .UseInMemoryDatabase(databaseName: "TesteFuncionario")
    .Options;
            using (var context = new StunningContext(options))
            {
                HomeController homeController = new HomeController(context);
                var responseFuncionario = homeController.GetPorNome("Ada Aanderud");

                Assert.IsNotNull(responseFuncionario);
                Assert.IsNotNull(responseFuncionario.Value);
                Assert.IsNotNull(responseFuncionario.Value.Count > 0);
            }

        }
        [Test]
        public void CpfExistente()
        {
            var options = new DbContextOptionsBuilder<StunningContext>()
    .UseInMemoryDatabase(databaseName: "TesteFuncionario")
    .Options;
            using (var context = new StunningContext(options))
            {
                HomeController homeController = new HomeController(context);
                var responseFuncionario = homeController.GetPorCpf("41851452257");

                Assert.IsNotNull(responseFuncionario);
                Assert.IsNotNull(responseFuncionario.Value);
                Assert.IsNotNull(responseFuncionario.Value.Count > 0);
            }

        }
        [Test]
        public void UfExistente()
        {
            var options = new DbContextOptionsBuilder<StunningContext>()
    .UseInMemoryDatabase(databaseName: "TesteFuncionario")
    .Options;
            using (var context = new StunningContext(options))
            {
                HomeController homeController = new HomeController(context);
                var responseFuncionario = homeController.GetPorUF("ES");

                Assert.IsNotNull(responseFuncionario);
                Assert.IsNotNull(responseFuncionario.Value);
                Assert.IsNotNull(responseFuncionario.Value.Count > 0);
            }

        }
        [Test]
        public void SalarioExistente()
        {
            var options = new DbContextOptionsBuilder<StunningContext>()
    .UseInMemoryDatabase(databaseName: "TesteFuncionario")
    .Options;
            using (var context = new StunningContext(options))
            {
                HomeController homeController = new HomeController(context);
                var responseFuncionario = homeController.GetPorSalario(0.0, 50000.0);

                Assert.IsNotNull(responseFuncionario);
                Assert.IsNotNull(responseFuncionario.Value);
                Assert.IsNotNull(responseFuncionario.Value.Count > 0);
            }

        }
        [Test]
        public void DataExistente()
        {
            var options = new DbContextOptionsBuilder<StunningContext>()
    .UseInMemoryDatabase(databaseName: "TesteFuncionario")
    .Options;
            using (var context = new StunningContext(options))
            {
                HomeController homeController = new HomeController(context);
                var responseFuncionario = homeController.GetPorData(DateTime.MinValue, DateTime.MaxValue);

                Assert.IsNotNull(responseFuncionario);
                Assert.IsNotNull(responseFuncionario.Value);
                Assert.IsNotNull(responseFuncionario.Value.Count > 0);
            }

        }
        [Test]
        public void StatusExistente()
        {
            var options = new DbContextOptionsBuilder<StunningContext>()
    .UseInMemoryDatabase(databaseName: "TesteFuncionario")
    .Options;
            using (var context = new StunningContext(options))
            {
                HomeController homeController = new HomeController(context);
                var responseFuncionario = homeController.GetPorStatus("ATIVO");

                Assert.IsNotNull(responseFuncionario);
                Assert.IsNotNull(responseFuncionario.Value);
                Assert.IsNotNull(responseFuncionario.Value.Count > 0);

            }

        }
        [Test]
        public void ValidarSave()
        {
            var options = new DbContextOptionsBuilder<StunningContext>()
    .UseInMemoryDatabase(databaseName: "TesteFuncionario")
    .Options;
            using (var context = new StunningContext(options))
            {
                HomeController homeController = new HomeController(context);

                var funcionario = new Funcionarios { DataCad = DateTime.Parse("02/04/2017"), Cargo = "AC Pl", Cpf = "68557675240", Nome = "Adolph Abajian", UfNasc = "MS", Salario = 3429.10, Status = "ATIVO" };

                var success = homeController.Post(funcionario);
                Assert.AreEqual(success.Value, true);


            }
        }
        [Test]
        public void ValidarEdit()
        {
            var options = new DbContextOptionsBuilder<StunningContext>()
    .UseInMemoryDatabase(databaseName: "TesteFuncionario")
    .Options;
            using (var context = new StunningContext(options))
            {
                HomeController homeController = new HomeController(context);
                var funcionario = new Funcionarios { IdFuncionario = 1,
                    DataCad = DateTime.Parse("16/04/2017"),
                    Cargo = "Analista Jr",
                    Cpf = "3423",
                    Nome = "Ada Aanderud",
                    UfNasc = "ES",
                    Salario = 1355.10,
                    Status = "ATIVO"
                };

                var success = homeController.Put(1,funcionario);
                Assert.AreEqual(success.Value, true);
            }
        }
        [Test]
        public void ValidarEditIncorreto()
        {
            var options = new DbContextOptionsBuilder<StunningContext>()
    .UseInMemoryDatabase(databaseName: "TesteFuncionario")
    .Options;
            using (var context = new StunningContext(options))
            {
                HomeController homeController = new HomeController(context);

                var funcionario = new Funcionarios { IdFuncionario = 1, DataCad = DateTime.Parse("02/04/2017"), Cargo = "AC Pl", Cpf = "68557675240", Nome = "Adolph Abajian", UfNasc = "MS", Salario = 3429.10, Status = "ATIVO" };

                var success = homeController.Put(1, funcionario);
                Assert.AreEqual(success.Value, false);
            }
        }
        [Test]
        public void DeleteIncorreto()
        {
            var options = new DbContextOptionsBuilder<StunningContext>()
    .UseInMemoryDatabase(databaseName: "TesteFuncionario")
    .Options;
            using (var context = new StunningContext(options))
            {
                HomeController homeController = new HomeController(context);

                var funcionario = new Funcionarios { IdFuncionario = 23, DataCad = DateTime.Parse("02/04/2017"), Cargo = "AC Pl", Cpf = "68557675240", Nome = "Adolph Abajian", UfNasc = "MS", Salario = 3429.10, Status = "ATIVO" };

                var success = homeController.Delete(funcionario);
                Assert.AreEqual(success.Value, false);
            }
        }
        [Test]
        public void DeleteCorreto()
        {
            var options = new DbContextOptionsBuilder<StunningContext>()
    .UseInMemoryDatabase(databaseName: "TesteFuncionario")
    .Options;
            using (var context = new StunningContext(options))
            {
                HomeController homeController = new HomeController(context);
                var funcionario = new Funcionarios { IdFuncionario = 1, DataCad = DateTime.Parse("02/04/2017"), Cargo = "AC Pl", Cpf = "68557675240", Nome = "Adolph Abajian", UfNasc = "MS", Salario = 3429.10, Status = "ATIVO" };

                var success = homeController.Delete(funcionario);
                Assert.AreEqual(success.Value, true);
            }
        }
        [Test]
        public void DeleteCpfInCorreto()
        {
            var options = new DbContextOptionsBuilder<StunningContext>()
    .UseInMemoryDatabase(databaseName: "TesteFuncionario")
    .Options;
            using (var context = new StunningContext(options))
            {
                HomeController homeController = new HomeController(context);

                var funcionario = new Funcionarios { IdFuncionario = 23, DataCad = DateTime.Parse("02/04/2017"), Cargo = "AC Pl", Cpf = "68557675240", Nome = "Adolph Abajian", UfNasc = "MS", Salario = 3429.10, Status = "ATIVO" };

                var success = homeController.Delete("1");
                Assert.AreEqual(success.Value, false);
            }
        }
        [Test]
        public void DeleteCPFCorreto()
        {
            var options = new DbContextOptionsBuilder<StunningContext>()
    .UseInMemoryDatabase(databaseName: "TesteFuncionario")
    .Options;
            using (var context = new StunningContext(options))
            {
                HomeController homeController = new HomeController(context);
                var funcionario = new Funcionarios { IdFuncionario = 23, DataCad = DateTime.Parse("02/04/2017"), Cargo = "AC Pl", Cpf = "68557675240", Nome = "Adolph Abajian", UfNasc = "MS", Salario = 3429.10, Status = "ATIVO" };

                var success = homeController.Delete("41851452257");
                Assert.AreEqual(success.Value, true);
            }
        }
    }
}
