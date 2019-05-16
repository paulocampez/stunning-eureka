using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static Stunnig.API.Models.DDD;

namespace Stunnig.API.Models.Strategies.Database
{
    public class FileStrategy : IFuncionarioREST
    {

        public List<DDD.Funcionario> ReadConfigFile(string pathConfigFile)
        {
            List<DDD.Funcionario> lstFuncionarios = new List<DDD.Funcionario>();
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
                //DataCad;Cargo;Cpf;Nome;UfNasc;Salario;Status
                //15/04/2017;Dev Jr;85235708709;Aaron Aaberg;AP;8965.30;ATIVO
                Funcionario funcionario = new Funcionario();
                if (DateTime.TryParse(arrayFuncionario[0].ToString(), out dateResult))
                    funcionario.DataCad = dateResult;
                funcionario.Cargo = arrayFuncionario[1].ToString();
                funcionario.Cpf = arrayFuncionario[2].ToString();
                funcionario.Nome = arrayFuncionario[3].ToString();
                funcionario.UfNasc = arrayFuncionario[4].ToString();
                if (decimal.TryParse(arrayFuncionario[5].ToString(), style, culture, out salario))
                    funcionario.Salario = salario;
                funcionario.Status = arrayFuncionario[6].ToString();

                lstFuncionarios.Add(funcionario);
            }

            return lstFuncionarios;
        }
        public List<DDD.Funcionario> GetFuncionarios()
        {
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            string path = "\\funcionarios.txt";
            return ReadConfigFile(_filePath += path);
        }
    }
}
