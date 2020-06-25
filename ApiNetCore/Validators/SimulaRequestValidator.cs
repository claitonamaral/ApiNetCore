using ApiNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiNetCore.Validators
{
    public class SimulaRequestValidator
    {
        public bool IsValid(CalculaJuros calculo)
        {
            bool resposta = true;

            if (string.IsNullOrEmpty(calculo.ValorFinal.ToString()))
                resposta = false;

            return resposta;
        }

        public bool IsValid(TaxaJuros taxaJuros)
        {
            bool resposta = true;

            if (string.IsNullOrEmpty(taxaJuros.Juros.ToString()))
                resposta = false;

            return resposta;
        }
    }
}
