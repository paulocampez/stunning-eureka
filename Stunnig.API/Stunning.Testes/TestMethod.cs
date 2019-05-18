using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using Stunnig.API;
using Stunnig.API.Controllers;
using Stunnig.Data;
using Stunning.Model;
using Stunning.MVC;
using System;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        public StunningContext _context;


        [SetUp]
        public void Setup()
        {


        }

        [Test]
        public void Test1()
        {
            var options = new DbContextOptionsBuilder<StunningContext>()
        .UseInMemoryDatabase(databaseName: "TesteFuncionario")
        .Options;
            List<Funcionarios> lista = new List<Funcionarios>();
            using (var context = new StunningContext(options))
            {
                context.Funcionarios.Add(
                    new Funcionarios { DataCad = DateTime.Parse("16/04/2017"), Cargo = "Analista Jr",
                        Cpf = "41851452257", Nome = "Ada Aanderud", UfNasc = "ES", Salario = 1355.10, Status = "ATIVO" }
                    );
                context.SaveChanges();

                HomeController homeController = new HomeController(context);
                lista = homeController.GetPorCpf("CPFQUENAOEXISTE");

            }
            Assert.IsTrue(lista.Count == 0);
        }
    }
}