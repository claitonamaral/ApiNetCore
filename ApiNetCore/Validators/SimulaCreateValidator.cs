using ApiNetCore.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiNetCore.Validators
{
    public class SimulaCreateValidator
    {
        CalculaJuros _calculo;
        TaxaJuros _taxaJuros;

        public SimulaCreateValidator(CalculaJuros calculo, TaxaJuros taxaJuros)
        {
            _calculo = calculo;
            _taxaJuros = taxaJuros;
        }

        public List<string> IsValid()
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrEmpty(_taxaJuros.Juros.ToString()))
                errors.Add("Sem taxa de juros informado!");

            if (string.IsNullOrEmpty(_calculo.ValorFinal.ToString()))
                errors.Add("Não foi possível calcular!");

            return errors;
        }
    }
}
