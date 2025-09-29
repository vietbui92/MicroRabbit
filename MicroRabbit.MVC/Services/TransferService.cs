using MicroRabbit.MVC.Models.DTOs;
using Newtonsoft.Json;
using System.Text;

namespace MicroRabbit.MVC.Services
{
    public class TransferService(HttpClient apiClient) : ITransferService
    {
        private readonly HttpClient _apiClient = apiClient;

        public async Task Transfer(TransferDto transferDto)
        {
            var uri = "https://localhost:5001/api/Banking";
            var transferContent = new StringContent(JsonConvert.SerializeObject(transferDto), Encoding.UTF8, "application/json");
            var response = await _apiClient.PostAsync(uri, transferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}
