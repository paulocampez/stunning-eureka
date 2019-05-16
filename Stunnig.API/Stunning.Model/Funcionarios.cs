using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stunning.Model
{
    public class Funcionarios
    {
        public int? IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime? DataCad { get; set; }
        public string Cargo { get; set; } //TODO: Enum
        public string UfNasc { get; set; }
        public decimal? Salario { get; set; }
        public string Status { get; set; } //TODO: Enum
    }
}
