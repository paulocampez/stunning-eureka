using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Stunnig.API.Models.DDD;

namespace Stunnig.API.Models
{
    public class PostFuncionariosRequest
    {
    }

    public static class Extensions
    {
        public static Funcionario ToEntity(this PostFuncionariosRequest request) => new Funcionario
        {

        };
    }
}
