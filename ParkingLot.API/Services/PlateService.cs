using ParkingLot.Core;
using System.Text.Json;

namespace ParkingLot.API.Services
{
    public class PlateService
    {
        private readonly HttpClient _httpClient;

        public PlateService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public bool CheckPlateHaving(string plate) {
            return true;
        }

        public async Task<string> DetectPlate(IFormFile carImage) {

            using var content = new MultipartFormDataContent();

            using var stream = carImage.OpenReadStream();

            var streamContent = new StreamContent(stream);

            content.Add(streamContent, "file", carImage.FileName);

            var response = await _httpClient.PostAsync(
                "https://localhost:5000/",
                content
            );

            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<PlateResponse>(json);

            return result.plate;
        
        }


    }
}
