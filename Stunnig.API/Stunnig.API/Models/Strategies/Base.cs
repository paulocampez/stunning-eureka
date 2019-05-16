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

        public List<Funcionarios> GetFuncionariosPorCargo()
        {
            return _funcionarioRest.GetFuncionariosPorCargo();
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
            throw new NotImplementedException();
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
