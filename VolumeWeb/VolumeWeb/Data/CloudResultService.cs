using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using VolumeWebService.VolumeCalculator;

namespace VolumeWeb.Data
{
    public class CloudResultService:IResultService
    {
        private string uri = "https://localhost:5003";
        
        private readonly HttpClient client;

        public CloudResultService()
        {
            client = new HttpClient();
        }
        
        public async Task<IList<VolumeResult>> GetResultsAsync()
        {
            Task<string> stringAsync = client.GetStringAsync(uri + "/Calculate");
            string message = await stringAsync;
            Console.WriteLine(message);
            List<VolumeResult> result = JsonSerializer.Deserialize<List<VolumeResult>>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return result;
        }

        public async Task AddResultAsync(VolumeResult result)
        {
           
        }

        public async Task RemoveVolumeResultAsync(int id)
        {
            await client.DeleteAsync($"{uri}/Calculate/{id}");
        }

        public async Task CalculateVolumeCylinder(double height, double radius)
        {
            await client.GetAsync($"{uri}/Calculate/cylinder?height={height}&radius={radius}");
        }

        public async Task CalculateVolumeCone(double height, double radius)
        {
            await client.GetAsync($"{uri}/Calculate/cone?height={height}&radius={radius}");
        }
    }
}