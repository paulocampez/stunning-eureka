using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Stunning.Model;
using static Stunnig.API.Models.DDD;

namespace Stunnig.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StunningDbContext context)
        {
            if (context.Funcionarios.Any())
            {
                return;   // Banco alimentado
            }

            var funcionarios = new Funcionarios[]
            {
                new Funcionarios { Nome = "", Cargo = "", Cpf = "", DataCad = DateTime.Now, IdFuncionario = 1, Salario = 1, Status = "", UfNasc = "" },

            };

            foreach (Funcionarios s in funcionarios)
            {
                context.Funcionarios.Add(s);
            }
            context.SaveChanges();


        }
    }
}