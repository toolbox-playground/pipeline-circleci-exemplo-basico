// Tests/BasicTests.cs
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;
using System.Net.Http;

public class BasicTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public BasicTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task Get_ReturnsHelloWorld()
    {
        // Arrange & Act
        var response = await _client.GetAsync("/");
        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();

        // Assert
        Assert.Equal("Hello, World!", responseString);
    }
}
