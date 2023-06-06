using project_geopet.Request;

namespace project_geopet.Middleware;

public static class CaringPersonMiddleware
{
    public static bool ValidCep(CaringPersonRequest request)
    {
        string URL = $"https://viacep.com.br/ws/{request.Cep}/json/";

        HttpClient client = new();
        HttpResponseMessage response = client.GetAsync(URL).GetAwaiter().GetResult();

        if (response.IsSuccessStatusCode)
        {
            return true;
        }
        return false;
    }
}