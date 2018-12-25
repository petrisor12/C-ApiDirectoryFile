using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using EsercitazioneApiDirectoryFile.ProgettoApi.Models;

namespace EsercitazioneApiDirectoryFile.ProgettoConsole
{// atenzione serve il pachetto nuget Microsoft.AspNet.WebApi.Client e newtonsoft.json
    class Program
    {
        public static HttpClient client = new HttpClient();

        static void Main(string[] args)

        {
            client.BaseAddress = new Uri("http://localhost:5001/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var dati = GetProductAsync("https://localhost:5001/api/dati").Result;

            Console.WriteLine(dati.Name
            +"sfads");
            Show(dati);








        }
        static void Show(FolderModel dati) {

           
            foreach (var n in dati.FolderChildren)
            {

                Console.WriteLine("-----"+ n.Name
                );
               
                Show(n);

            }

           
            foreach (var m in dati.FileChildren)
            {
                Console.WriteLine("---------------" + m.Name + " e size" + m.Size);
            }
        }


        static async Task<FolderModel> GetProductAsync(string path)
        {
            FolderModel dati = null;

            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                // qui si deserializza da json in rootObject
                dati = await response.Content.ReadAsAsync<FolderModel>();


            }
            return dati;
        }




}

}