using Microsoft.AspNetCore.Mvc;
using project_geopet.Request;

namespace project_geopet.Middleware;

public class CepMiddleware
{
    private readonly IHttpClientFactory _clientFactory;

    public CepMiddleware(IHttpClientFactory httpClientFactory)
    {
        _clientFactory = httpClientFactory;
    }
    public async Task<bool> ValidCep(CaringPersonRequest request)
    {
        var client = _clientFactory.CreateClient();
        var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"https://viacep.com.br/ws/" + request.Cep + "/json/");
        requestMessage.Headers.Add("Accept", "application/json");
        var response = await client.SendAsync(requestMessage);
        if (response.IsSuccessStatusCode)
        {
            return true;
        }
        return false;
    }
}