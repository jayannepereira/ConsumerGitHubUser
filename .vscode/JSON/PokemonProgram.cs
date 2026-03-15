using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsumerPokeApi
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write("Digite o nome de um Pokemon: ");
            string nomePokemon = Console.ReadLine().ToLower().Trim();

            string url = $"https://pokeapi.co/api/v2/pokemon/{nomePokemon}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonString = await response.Content.ReadAsStringAsync();
                        var poke = JsonSerializer.Deserialize<Pokemon>(jsonString);

                        Console.WriteLine("\nRetorno da API:");
                        Console.WriteLine($"Id: {poke.Id}");
                        Console.WriteLine($"Nome: {poke.Nome}");
                        Console.WriteLine($"Altura: {poke.Altura}");
                        Console.WriteLine($"Peso: {poke.Peso}");
                    }
                    else
                    {
                        Console.WriteLine("Erro: Pokemon não encontrado. Verifique a grafia.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro na requisição: {ex.Message}");
                }
            }
        }
    }
}