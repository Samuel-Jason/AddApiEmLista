using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace teste1
{
    internal class Program : MeuObjeto
    {
        static async Task Main(string[] args)
        {
            string apiUrl = "https://api.adviceslip.com/advice";

            // Instanciar o HttpClient
            using (HttpClient client = new HttpClient())
            {
                List<MeuObjeto> minhaLista = new List<MeuObjeto>();

                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string conteudo = await response.Content.ReadAsStringAsync();
                        
                        MeuObjeto objetosDaConsulta = JsonConvert.DeserializeObject<MeuObjeto>(conteudo);
                        minhaLista.Add(objetosDaConsulta);


                        foreach(MeuObjeto item in minhaLista)
                        {
                            Console.WriteLine($"Id: {item.Id}, Advice: {item.Advice}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}