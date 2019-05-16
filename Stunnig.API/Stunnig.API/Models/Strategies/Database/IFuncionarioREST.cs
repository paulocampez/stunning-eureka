using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stunning.Model;

namespace Stunnig.API.Models.Strategies.Database
{
    public interface IFuncionarioREST
    {
        List<Funcionarios> GetFuncionarios();
        //bool Insert();
        //bool Put();
        //bool Delete();
        List<Funcionarios> GetFuncionariosPorNome(string nome);
        List<Funcionarios> GetFuncionariosPorCPF(string cpf);
        List<Funcionarios> GetFuncionariosPorCargo(string cargo);
        //List<Funcionario> GetFuncionariosPorData();
        //List<Funcionario> GetFuncionariosAgrupadosPorUF();
        List<Funcionarios> GetFuncionariosPorFaixaSalarial(decimal faixa1, decimal faixa2);
        List<Funcionarios> GetFuncionariosPorStatus(string status);
    }
}
