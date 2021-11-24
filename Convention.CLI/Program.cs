using Convention.CLI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Convention.CLI
{

    internal class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:17912/");

            Console.WriteLine("Введите имя:");
            var name = Console.ReadLine();

            Console.WriteLine("Введите номер договора:");
            var number = Console.ReadLine();

            Console.WriteLine("Введите сумму:");
            var payment = Console.ReadLine();

            var data = new
            {
                Name = name,
                Number = number,
                Payment = payment
            };
            var content = ConvertToByteArray(data);
            var result = client.PostAsync("api/convention/generate",content).Result;
            
            var console = result.Content.ReadAsStringAsync().Result;
            //var obj = JsonConvert.DeserializeObject<ConventionResult>(console);
            Console.WriteLine(console);
            Console.ReadLine();


            
            
        }
        static ByteArrayContent ConvertToByteArray(object data)
        {
            var serialized = JsonConvert.SerializeObject(data);
            var bytes = System.Text.Encoding.UTF8.GetBytes(serialized);
            var content = new ByteArrayContent(bytes);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return content;
        }
    }
}
