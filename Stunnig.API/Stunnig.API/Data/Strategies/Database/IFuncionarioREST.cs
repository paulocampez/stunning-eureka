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
        bool Post(Funcionarios funcionario);
        bool Put(Funcionarios funcionario, int id);
        bool Delete(Funcionarios funcionario);
        bool DeletePorCpf(string cpf);
        List<Funcionarios> GetFuncionariosPorNome(string nome);
        List<Funcionarios> GetFuncionariosPorCPF(string cpf);
        List<Funcionarios> GetFuncionariosPorCargo(string cargo);
        List<Funcionarios> GetFuncionariosPorData(DateTime dataInicio, DateTime dataFim);
        List<Funcionarios> GetFuncionariosAgrupadosPorUF(string UF);
        List<Funcionarios> GetFuncionariosPorFaixaSalarial(double faixa1, double faixa2);
        List<Funcionarios> GetFuncionariosPorStatus(string status);
    }
}
