namespace project_geopet.Services;

public static class GetLocation
{
    public static async Task<string?> AddressByLocation(float lat, float lon)
    {
        string URL = $"https://nominatim.openstreetmap.org/reverse?format=json&lat={lat}&lon={lon}&addressdetails=1";

        using HttpClient client = new();
        HttpResponseMessage response = client.GetAsync(URL).GetAwaiter().GetResult();
        
            string jsonResponse = await response.Content.ReadAsStringAsync();
            return jsonResponse;
    }
}