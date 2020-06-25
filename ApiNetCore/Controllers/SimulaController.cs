﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiNetCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using System.Net.Http;

namespace ApiNetCore.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SimulaController : ControllerBase
    {
        HttpClient client = new HttpClient();

        // GET api/taxaJuros
        [HttpGet("taxaJuros")]
        public Double GetTaxaJuros()
        {
            Double _taxa = 0.01;
            TaxaJuros taxa = new TaxaJuros();
            taxa.Juros = _taxa;
            return taxa.Juros;
        }

        // GET: api/calculajuros/1
        [HttpGet("calculajuros/valorincial={valorInicial}/meses={tempo}")]
        public Double GetCalculaJuros([FromRoute] decimal valorInicial, [FromRoute] int tempo)
        {
            CalculaJuros calculaJuros = new CalculaJuros();
            calculaJuros.Juros = GetTaxaJuros();
            calculaJuros.ValorInicial = (Double)valorInicial;
            calculaJuros.Tempo = tempo;
            var taxaJuros = GetTaxaJuros();
            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("http://localhost:56401/api/");
            //    var retorno = client.GetAsync("TaxaJuros");
            //    var result = retorno.Result;
            //    if (result.IsSuccessStatusCode)
            //    {
            //        var conteudo = result.Content.ReadAsAsync<Double>();
            //        var taxaJuros = conteudo.Result;
            //        calculaJuros.Juros = taxaJuros;
            //    }
            //}

            calculaJuros.ValorFinal = calculaJuros.ValorInicial * Math.Pow((1 + calculaJuros.Juros), calculaJuros.Tempo);

            return Math.Truncate(100 * calculaJuros.ValorFinal) / 100;
        }
    }
}
