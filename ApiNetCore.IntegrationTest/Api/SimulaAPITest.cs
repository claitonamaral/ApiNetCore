﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace ApiNetCore.IntegrationTest.Api
{
    public class SimulaAPITest
    {
        private readonly HttpClient _client;

        public SimulaAPITest()
        {
            var server = new TestServer(new WebHostBuilder()
                .UseEnvironment("Development")
                .UseStartup<Startup>());
            _client = server.CreateClient();
        }

        [Theory]
        [InlineData("GET")]
        public async Task TaxaJurosTestAsync(string method)
        {
            //Arrange
            var request = new HttpRequestMessage(new HttpMethod(method), "/Simula/taxaJuros/");

            //Act
            var response = await _client.SendAsync(request);

            //Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Theory]
        [InlineData("GET", 100, 5)]
        public async Task CalculaJurosTestAsync(string method, int? valorinicial = null, int? tempo = null)
        {
            //Arrange
            var request = new HttpRequestMessage(new HttpMethod(method), $"/Simula/calculajuros/valorincial={valorinicial}/meses={tempo}/");

            //Act
            var response = await _client.SendAsync(request);

            //Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

    }
}
