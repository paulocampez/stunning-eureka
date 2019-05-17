using Stunnig.API.Models.Strategies.Database;
using Stunning.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stunnig.API.Models.Strategies
{
    public class Context : IFuncionarioREST
    {
        private IFuncionarioREST _funcionarioRest;

        public Context(IFuncionarioREST iFuncionarioREST)
        {
            _funcionarioRest = iFuncionarioREST;
        }

        public bool Delete(Funcionarios funcionario)
        {
            return _funcionarioRest.Delete(funcionario);
        }

        public List<Funcionarios> GetFuncionarios()
        {
            return _funcionarioRest.GetFuncionarios();
        }

        public List<Funcionarios> GetFuncionariosAgrupadosPorUF(string UF)
        {
            return _funcionarioRest.GetFuncionariosAgrupadosPorUF(UF);
        }

        public List<Funcionarios> GetFuncionariosPorCargo(string cargo)
        {
            return _funcionarioRest.GetFuncionariosPorCargo(cargo);
        }

        public List<Funcionarios> GetFuncionariosPorCPF(string cpf)
        {
            return _funcionarioRest.GetFuncionariosPorCPF(cpf);
        }

        public List<Funcionarios> GetFuncionariosPorData(DateTime dataInicio, DateTime dataFim)
        {
            return _funcionarioRest.GetFuncionariosPorData(dataInicio, dataFim);
        }

        public List<Funcionarios> GetFuncionariosPorFaixaSalarial(decimal faixa1, decimal faixa2)
        {
            return _funcionarioRest.GetFuncionariosPorFaixaSalarial(faixa1, faixa2);
        }


        public List<Funcionarios> GetFuncionariosPorNome(string nome)
        {
            return _funcionarioRest.GetFuncionariosPorNome(nome);
        }

        public List<Funcionarios> GetFuncionariosPorStatus(string status)
        {
            return _funcionarioRest.GetFuncionariosPorStatus(status);
        }

        public bool Post(Funcionarios funcionario)
        {
            return _funcionarioRest.Post(funcionario);
        }

        public bool Put(Funcionarios funcionario)
        {
            return _funcionarioRest.Put(funcionario);
        }
    }
}
