using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace TheShopCore
{
    class Program
    {
        static HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            // Call API Service save test data to in memory DB service can be created to save custom data but this is more obvious for testing purposes.
            client.PostAsync("http://localhost:53329/TheShopCore/SaveArticle", null).GetAwaiter().GetResult();

            try
            {
                //order and sell
                Uri uri = new Uri("http://localhost:53329/TheShopCore?id=1&maxExpectedPrice=20&buyerId=10");

                client.PostAsync(uri,null).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            try
            {
                //print article on console
                var article = client.GetAsync("http://localhost:53329/TheShopCore?Id=1").GetAwaiter().GetResult();
                Console.WriteLine("Found article with ID: " + article);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Article not found: " + ex);
            }

            try
            {
                //print article on console				
                var article = client.GetAsync("http://localhost:53329/TheShopCore?Id=12").GetAwaiter().GetResult();
                Console.WriteLine("Found article with ID: " + article);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Article not found: " + ex);
            }

            Console.ReadKey();
        }
    }
}
