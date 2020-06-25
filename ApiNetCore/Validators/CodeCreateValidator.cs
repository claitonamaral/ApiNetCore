using ApiNetCore.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiNetCore.Validators
{
    public class CodeCreateValidator
    {
        Code _code;

        public CodeCreateValidator(Code code)
        {
            _code = code;
        }

        public List<string> IsValid()
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrEmpty(_code.url))
                errors.Add("URL do código não foi encontrada!");

            return errors;
        }
    }
}
