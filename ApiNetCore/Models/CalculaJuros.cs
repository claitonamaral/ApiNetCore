using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiNetCore.Models
{
    public class CalculaJuros
    {
        public Double ValorFinal { set; get; }
        public Double ValorInicial { set; get; }
        public Double Juros { set; get; }
        public int Tempo { set; get; }
    }
}
