using Stunning.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stunning.Model
{
    public class Funcionarios
    {
        [Key]
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCad { get; set; }
        public string Cargo { get; set; }
        public string UfNasc { get; set; }
        public double Salario { get; set; }
        public string Status { get; set; }
    }

}
