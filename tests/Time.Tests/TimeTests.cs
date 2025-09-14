using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using Time.API;

namespace Time.Tests
{
    public class TimeTests : IClassFixture<WebApplicationFactory<Program>>
    {

        private readonly WebApplicationFactory<Program> _factory;
        private readonly HttpClient _client;

        public TimeTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
            _client = _factory.CreateClient();
        }

        [Fact]
        public async Task TimeEndpoint_ReturnsCurrentUtcTime()
        {
            // Arrange & Act
            var response = await _client.GetAsync("/time");

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var jsonString = await response.Content.ReadAsStringAsync();
            var timeString = jsonString.Trim('"');

            // Assert
            Assert.NotNull(timeString);
            Assert.True(DateTime.TryParse(timeString, out DateTime parsedTime));
        }
    }
}
