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

        //public bool Delete()
        //{
        //    return _funcionarioRest.Delete();
        //}

        public List<Funcionarios> GetFuncionarios()
        {
            return _funcionarioRest.GetFuncionarios();
        }

        //public List<DDD.Funcionario> GetFuncionariosAgrupadosPorUF()
        //{
        //    return _funcionarioRest.GetFuncionariosAgrupadosPorUF();
        //}

        public List<Funcionarios> GetFuncionariosPorCargo(string cargo)
        {
            return _funcionarioRest.GetFuncionariosPorCargo(cargo);
        }

        public List<Funcionarios> GetFuncionariosPorCPF(string cpf)
        {
            return _funcionarioRest.GetFuncionariosPorCPF(cpf);
        }

        public List<Funcionarios> GetFuncionariosPorFaixaSalarial(decimal faixa1, decimal faixa2)
        {
            return _funcionarioRest.GetFuncionariosPorFaixaSalarial(faixa1, faixa2);
        }

        //public List<DDD.Funcionario> GetFuncionariosPorCPF()
        //{
        //    throw new NotImplementedException();
        //}

        //public List<DDD.Funcionario> GetFuncionariosPorData()
        //{
        //    throw new NotImplementedException();
        //}

        //public List<DDD.Funcionario> GetFuncionariosPorFaixaSalarial()
        //{
        //    throw new NotImplementedException();
        //}

        public List<Funcionarios> GetFuncionariosPorNome(string nome)
        {
            return _funcionarioRest.GetFuncionariosPorNome(nome);
        }

        public List<Funcionarios> GetFuncionariosPorStatus(string status)
        {
            return GetFuncionariosPorStatus(status);
        }

        //public List<DDD.Funcionario> GetFuncionariosPorStatus()
        //{
        //    throw new NotImplementedException();
        //}

        //public bool Insert()
        //{
        //    throw new NotImplementedException();
        //}

        //public bool Put()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
