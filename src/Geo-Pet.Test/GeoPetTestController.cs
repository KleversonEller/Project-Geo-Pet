using FluentAssertions;
using System.Net;
using Xunit;

namespace project_geopet.Test;

public class TestController : IClassFixture<GeoPetTestContext<Program>>
{
    private readonly HttpClient _client;
    public TestController(GeoPetTestContext<Program> factory)
    {
        _client = factory.CreateClient();
    }


    [Theory]
    [InlineData("/CaringPerson")]
    public async Task GetAllCaringPerson(string url)
    {
        var result = await _client.GetAsync(url);

        result.StatusCode.Should().Be((HttpStatusCode)200);
    }
}