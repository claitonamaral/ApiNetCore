using ApiNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiNetCore.Validators
{
    public class CodeRequestValidator
    {
        public bool IsValid(Code code)
        {
            bool resposta = true;

            if (string.IsNullOrEmpty(code.url))
                resposta = false;

            return resposta;
        }
    }
}
