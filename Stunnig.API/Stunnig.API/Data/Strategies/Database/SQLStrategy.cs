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

        const string cmdGetAll = "SELECT * "
                        + "FROM Funcionarios ";

        const string cmdGetAllByCargo = "SELECT * "
                       + "FROM Funcionarios WHERE Cargo = ':Cargo'";
        const string cmdGetAllByNome = "SELECT * "
                 + "FROM Funcionarios WHERE Nome = ':Nome'";
        const string cmdGetAllByCpf = "SELECT * "
               + "FROM Funcionarios WHERE Cpf = ':Cpf'";

        const string cmdGetAllByStatus = "SELECT * "
                 + "FROM Funcionarios WHERE Status = ':Status'";

        const string cmdGetByDateRange = "SELECT* from Funcionarios where (DataCad BETWEEN ':DataInicio' AND ':DataFim')";

        const string cmdGetBySalarioRange = "SELECT* from Funcionarios where (Salario BETWEEN ':Faixa1' AND ':Faixa2')";

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
            Funcionarios funcionarios = _context.Funcionarios.Find(funcionario.IdFuncionario);
            _context.Funcionarios.Remove(funcionarios);
            _context.SaveChanges();
            return true;
        }

        public List<Funcionarios> GetFuncionarios()
        {

            List<Funcionarios> listaFuncionairos = new List<Funcionarios>();
            var conn = _context.Database.GetDbConnection();
            try
            {
                double doubFunc;
                conn.Open();
                using (var command = conn.CreateCommand())
                {


                    command.CommandText = cmdGetAll;
                    DbDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            double.TryParse(reader["Salario"].ToString(), out doubFunc);
                            var row = new Funcionarios
                            {
                                IdFuncionario = int.Parse(reader["IdFuncionario"].ToString()),
                                Cargo = reader["Cargo"].ToString(),
                                Cpf = reader["Cpf"].ToString(),
                                Nome = reader["Nome"].ToString(),
                                DataCad = DateTime.Parse(reader["DataCad"].ToString()),
                                Salario = doubFunc,
                                Status = reader["Status"].ToString(),
                                UfNasc = reader["UfNasc"].ToString()
                            };

                            listaFuncionairos.Add(row);
                        }
                    }
                    reader.Dispose();
                }
            }
            finally
            {
                conn.Close();
            }

            return listaFuncionairos;

        }

        public bool DeletePorCpf(string cpf)
        {
            List<Funcionarios> funcionarios = _context.Funcionarios.Where(p => p.Cpf == cpf).ToList();

            foreach (var funcionario in funcionarios)
                _context.Funcionarios.Remove(funcionario);

            _context.SaveChanges();

            return true;
        }

        public List<Funcionarios> GetFuncionariosAgrupadosPorUF(string UF)
        {
            return _context.Funcionarios.Where(p => p.UfNasc == UF).ToList();
        }

        public List<Funcionarios> GetFuncionariosPorCargo(string cargo)
        {
            return _context.Funcionarios.Where(p => p.Cargo == cargo).ToList();
        }

        public List<Funcionarios> GetFuncionariosPorCPF(string cpf)
        {
            return _context.Funcionarios.Where(p => p.Cpf == cpf).ToList();
        }

        public List<Funcionarios> GetFuncionariosPorData(DateTime dataInicio, DateTime dataFim)
        {
            return _context.Funcionarios.Where(c => c.DataCad >= dataInicio && c.DataCad <= dataFim).ToList();
        }

        public List<Funcionarios> GetFuncionariosPorFaixaSalarial(double faixa1, double faixa2)
        {
            return _context.Funcionarios.Where(p => p.Salario >= faixa1 && p.Salario <= faixa2).ToList();
        }

        public List<Funcionarios> GetFuncionariosPorNome(string nome)
        {
            List<Funcionarios> listaFuncionairos = new List<Funcionarios>();
            var conn = _context.Database.GetDbConnection();
            try
            {
                double doubFunc;
                conn.Open();
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = cmdGetAllByNome.Replace(":Nome", nome);
                    DbDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            double.TryParse(reader["Salario"].ToString(), out doubFunc);
                            var row = new Funcionarios
                            {
                                IdFuncionario = int.Parse(reader["IdFuncionario"].ToString()),
                                Cargo = reader["Cargo"].ToString(),
                                Cpf = reader["Cpf"].ToString(),
                                Nome = reader["Nome"].ToString(),
                                DataCad = DateTime.Parse(reader["DataCad"].ToString()),
                                Salario = doubFunc,
                                Status = reader["Status"].ToString(),
                                UfNasc = reader["UfNasc"].ToString()
                            };

                            listaFuncionairos.Add(row);
                        }
                    }
                    reader.Dispose();
                }
            }
            finally
            {
                conn.Close();
            }
            return listaFuncionairos;
        }

        public List<Funcionarios> GetFuncionariosPorStatus(string status)
        {
            List<Funcionarios> listaFuncionairos = new List<Funcionarios>();
            var conn = _context.Database.GetDbConnection();
            try
            {
                double doubFunc;
                conn.Open();
                using (var command = conn.CreateCommand())
                {

                    //TODO: Fazer ler AAAA-mm-DD
                    command.CommandText = cmdGetAllByStatus.Replace(":Status", status);
                    DbDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            double.TryParse(reader["Salario"].ToString(), out doubFunc);
                            var row = new Funcionarios
                            {
                                IdFuncionario = int.Parse(reader["IdFuncionario"].ToString()),
                                Cargo = reader["Cargo"].ToString(),
                                Cpf = reader["Cpf"].ToString(),
                                Nome = reader["Nome"].ToString(),
                                DataCad = DateTime.Parse(reader["DataCad"].ToString()),
                                Salario = doubFunc,
                                Status = reader["Status"].ToString(),
                                UfNasc = reader["UfNasc"].ToString()
                            };

                            listaFuncionairos.Add(row);
                        }
                    }
                    reader.Dispose();
                }
            }
            finally
            {
                conn.Close();
            }
            return listaFuncionairos;
        }

        public bool Post(Funcionarios funcionario)
        {
            if (_context.Funcionarios.Any(p => p == funcionario))
                _context.Entry(funcionario).State = EntityState.Modified;
            else
                _context.Funcionarios.Add(funcionario);

            _context.SaveChanges();
            return true;
        }

        public bool Put(Funcionarios funcionario, int id)
        {

            _context.SaveChanges();
            return true;
        }
    }
}
