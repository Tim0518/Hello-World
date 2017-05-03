using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeByHttpClient
{
    class Program
    {
        static HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            GetContent();
            Console.ReadKey();
        }
         async static void GetContent()
        {
            using (HttpResponseMessage reponse = await client.GetAsync("http://localhost:60636/api/HelloWorld"))
            { 
                using (HttpContent content = reponse.Content)
                {
                    string text = await content.ReadAsStringAsync();
                    Console.WriteLine(text);
                    Console.ReadLine();
                }
            }
        }
    }   
}
