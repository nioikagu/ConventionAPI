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
            Console.ReadLine();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:17912/");

            var data = new
            {
                Name = "VlaDICK",
                Number = "0008765",
                Payment = 666.6
            };
            var content = ConvertToByteArray(data);
            var result = client.PostAsync("api/convention/generate",content).Result;
            
            var console = result.Content.ReadAsStringAsync().Result;
            var obj = JsonConvert.DeserializeObject(console);
            
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
