using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsumerAdviceApi
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://api.adviceslip.com/advice";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string response = await client.GetStringAsync(url);

                    var adviceData = JsonSerializer.Deserialize<AdviceResponse>(response);

                    Console.WriteLine("Conselho de Hoje:");
                    Console.WriteLine(adviceData.Slip.Advice);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao buscar conselho: {ex.Message}");
                }
            }
        }
    }
}