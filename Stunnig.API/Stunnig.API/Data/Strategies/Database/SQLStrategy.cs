using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stunnig.Data;
using Stunning.Model;
namespace Stunnig.API.Models.Strategies.Database
{
    public class SQLStrategy : IFuncionarioREST
    {

        class FuncionarioDTO
        {
            public int Id;

            public string CustomerName;
        }


        private readonly StunningContext _context;

        public SQLStrategy()
        {
        }

        public SQLStrategy(StunningContext context)
        {
            _context = context;
        }
        public bool Delete(Funcionarios funcionario)
        {
            throw new NotImplementedException();
        }
        
        public List<Funcionarios> GetFuncionarios()
        {

            List<Funcionarios> groups = new List<Funcionarios>();
            var conn = _context.Database.GetDbConnection();
            try
            {
                double doubFunc;
                conn.Open();
                using (var command = conn.CreateCommand())
                {
                    string query = "SELECT * "
                        + "FROM Funcionarios ";

                    command.CommandText = query;
                    DbDataReader reader =  command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                           double.TryParse(reader["Salario"].ToString(), out doubFunc);
                           var row = new Funcionarios { IdFuncionario =  int.Parse(reader["IdFuncionario"].ToString()),
                                                        Cargo = reader["Cargo"].ToString(),
                                                        Cpf = reader["Cpf"].ToString(),
                                                        Nome = reader["Nome"].ToString(),
                                                        DataCad = DateTime.Parse(reader["DataCad"].ToString()),
                                                        Salario = doubFunc,
                                                        Status = reader["Status"].ToString(),
                                                        UfNasc = reader["UfNasc"].ToString()
                           };

                            groups.Add(row);
                        }
                    }
                    reader.Dispose();
                }
            }
            finally
            {
                conn.Close();
            }

            return groups;

        }

        public List<Funcionarios> GetFuncionariosAgrupadosPorUF(string UF)
        {
            throw new NotImplementedException();
        }

        public List<Funcionarios> GetFuncionariosPorCargo(string cargo)
        {
            throw new NotImplementedException();
        }

        public List<Funcionarios> GetFuncionariosPorCPF(string cpf)
        {
            throw new NotImplementedException();
        }

        public List<Funcionarios> GetFuncionariosPorData(DateTime dataInicio, DateTime dataFim)
        {
            throw new NotImplementedException();
        }

        public List<Funcionarios> GetFuncionariosPorFaixaSalarial(double faixa1, double faixa2)
        {
            throw new NotImplementedException();
        }

        public List<Funcionarios> GetFuncionariosPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Funcionarios> GetFuncionariosPorStatus(string status)
        {
            throw new NotImplementedException();
        }

        public bool Post(Funcionarios funcionario)
        {
            throw new NotImplementedException();
        }

        public bool Put(Funcionarios funcionario, int id)
        {
            throw new NotImplementedException();
        }
    }
}
