using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stunning.Model;
namespace Stunnig.API.Models.Strategies.Database
{
    public class SQLStrategy : IFuncionarioREST
    {
        public List<Funcionarios> GetFuncionarios()
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

        public List<Funcionarios> GetFuncionariosPorFaixaSalarial(decimal faixa1, decimal faixa2)
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
    }
}
