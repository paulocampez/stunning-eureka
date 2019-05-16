using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Stunnig.API.Models.DDD;

namespace Stunnig.API.Models.Strategies.Database
{
    public interface IFuncionarioREST
    {
        List<Funcionario> GetFuncionarios();
        //bool Insert();
        //bool Put();
        //bool Delete();
        //List<Funcionario> GetFuncionariosPorNome();
        //List<Funcionario> GetFuncionariosPorCPF();
        //List<Funcionario> GetFuncionariosPorCargo();
        //List<Funcionario> GetFuncionariosPorData();
        //List<Funcionario> GetFuncionariosAgrupadosPorUF();
        //List<Funcionario> GetFuncionariosPorFaixaSalarial();
        //List<Funcionario> GetFuncionariosPorStatus();
    }
}
