using Newtonsoft.Json;
using System;
using System.Net;

namespace RESTapi
{
    class Program
    {
        static void Main(string[] args)
        {
            String url = "https://my-json-server.typicode.com/RediGt/FakeRest/db";
            WebClient client = new WebClient();
            String response = client.DownloadString(url);
            Console.WriteLine(response);

            Container rec = JsonConvert.DeserializeObject<Container>(response);
            foreach (Students e in rec.students)
            {
                Console.WriteLine(e.lastName + "  " + e.age);
            }

            /*String url = "http://dummy.restapiexample.com/api/v1/employees";

            WebClient client = new WebClient();

            client.Headers.Add("Content-Type", "application/json");
            client.Headers.Add("Authentification-Token", "key");

            String response = client.DownloadString(url);

            //Console.WriteLine(response);

            Container rec = JsonConvert.DeserializeObject<Container>(response);

            if (rec.status == "success")
            {
                foreach (Employee e in rec.data)
                {
                    Console.WriteLine(e.employee_name);
                }
            }*/
        }
    }
}
