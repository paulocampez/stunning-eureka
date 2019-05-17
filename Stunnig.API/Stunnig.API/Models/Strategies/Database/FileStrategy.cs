using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Stunning.Model;

namespace Stunnig.API.Models.Strategies.Database
{
    public class FileStrategy : IFuncionarioREST
    {
        string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory) + "\\funcionarios.txt";
        public List<Funcionarios> GetFuncionariosPorArquivo(string pathConfigFile)
        {
            List<Funcionarios> lstFuncionarios = new List<Funcionarios>();
            DateTime dateResult = new DateTime();
            var culture = CultureInfo.CreateSpecificCulture("en-US");
            var style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;
            decimal salario = new decimal();
            var configInformation = new List<string>();
            using (var readerFileConfig = new StreamReader(pathConfigFile))
                while (readerFileConfig.Peek() >= 0)
                    configInformation.Add(readerFileConfig.ReadLine());

            for (int i = 1; i < configInformation.Count; i++)
            {
                var arrayFuncionario = configInformation[i].Split(';').ToList();
                Funcionarios funcionario = new Funcionarios();
                if (DateTime.TryParse(arrayFuncionario[0].ToString(), out dateResult))
                    funcionario.DataCad = dateResult;
                funcionario.Cargo = arrayFuncionario[1].ToString();
                funcionario.Cpf = arrayFuncionario[2].ToString();
                funcionario.Nome = arrayFuncionario[3].ToString();
                funcionario.UfNasc = arrayFuncionario[4].ToString();
                if (decimal.TryParse(arrayFuncionario[5].ToString(), style, culture, out salario))
                    funcionario.Salario = salario;
                funcionario.Status = arrayFuncionario[6].ToString();
                funcionario.IdFuncionario = i;

                lstFuncionarios.Add(funcionario);
            }

            return lstFuncionarios;
        }
        public List<Funcionarios> GetFuncionarios()
        {

            return GetFuncionariosPorArquivo(_filePath);
        }

        public List<Funcionarios> GetFuncionariosPorNome(string nome)
        {
            return GetFuncionariosPorArquivo(_filePath).Where(p => p.Nome == nome).ToList();
        }

        public List<Funcionarios> GetFuncionariosPorCPF(string cpf)
        {
            return GetFuncionariosPorArquivo(_filePath).Where(p => p.Cpf == cpf).ToList();
        }

        public List<Funcionarios> GetFuncionariosPorCargo(string cargo)
        {
            return GetFuncionariosPorArquivo(_filePath).Where(p => p.Cargo == cargo).ToList();
        }

        public List<Funcionarios> GetFuncionariosPorFaixaSalarial(decimal faixa1, decimal faixa2)
        {
            var minValue = faixa1 < faixa2 ? faixa1 : faixa2;
            var maxValue = faixa1 > faixa2 ? faixa1 : faixa2;
            return GetFuncionariosPorArquivo(_filePath).Where(p => p.Salario >= minValue && p.Salario <= maxValue).ToList();
        }

        public List<Funcionarios> GetFuncionariosPorStatus(string status)
        {
            return GetFuncionariosPorArquivo(_filePath).Where(p => p.Status == status).ToList();
        }

        public bool Post(Funcionarios funcionario)
        {
            using (var writeFileConfig = new StreamWriter(_filePath, append: true))
            {
                string saveInFile = funcionario.DataCad.ToShortDateString() + ";" + funcionario.Cargo + ";" + funcionario.Cpf + ";" + funcionario.Nome + ";" + funcionario.UfNasc + ";" + funcionario.Salario.ToString().Replace(',','.') + ";" + funcionario.Status;
                writeFileConfig.WriteLine(saveInFile);
                return true;
            }
        }

        public bool Put(Funcionarios funcionario, int id)
        {
            string editedFuncionarioFile = funcionario.DataCad.ToShortDateString() + ";" + funcionario.Cargo + ";" + funcionario.Cpf + ";" + funcionario.Nome + ";" + funcionario.UfNasc + ";" + funcionario.Salario.ToString().Replace(',', '.') + ";" + funcionario.Status;
            string[] arrLine = File.ReadAllLines(_filePath);
            arrLine[id] = editedFuncionarioFile;
            File.WriteAllLines(_filePath, arrLine);
            return true;
        }

        public bool Delete(Funcionarios funcionario)
        {
            string deleteFromFile = funcionario.DataCad.ToShortDateString() + ";" + funcionario.Cargo + ";" + funcionario.Cpf + ";" + funcionario.Nome + ";" + funcionario.UfNasc + ";" + funcionario.Salario.ToString().Replace(',', '.') + ";" + funcionario.Status;
            var tempFile = Path.GetTempFileName();
            var linesToKeep = File.ReadLines(_filePath).Where(l => l != deleteFromFile);

            File.WriteAllLines(tempFile, linesToKeep);

            File.Delete(_filePath);
            File.Move(tempFile, _filePath);
            return true;
        }

        public List<Funcionarios> GetFuncionariosPorData(DateTime dataInicio, DateTime dataFim)
        {
            throw new NotImplementedException();
        }

        public List<Funcionarios> GetFuncionariosAgrupadosPorUF(string UF)
        {
            throw new NotImplementedException();
        }
    }
}
