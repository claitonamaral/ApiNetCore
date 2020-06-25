using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace ApiNetCore.IntegrationTest.Api
{
    public class CoreAPITest
    {
        private readonly HttpClient _client;

        public CoreAPITest()
        {
            var server = new TestServer(new WebHostBuilder()
                .UseEnvironment("Development")
                .UseStartup<Startup>());
            _client = server.CreateClient();
        }

        [Theory]
        [InlineData("GET")]
        public async Task CoreGetTest(string method)
        {
            //Arrange
            var request = new HttpRequestMessage(new HttpMethod(method), "/Code/showmethecode/");

            //Act
            var response = await _client.SendAsync(request);

            //Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

    }
}
