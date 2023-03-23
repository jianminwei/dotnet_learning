
using System.Text.Json;

namespace dcf_client
{

    class Region
    {
        public long id { get; set; }
        public string name { get; set; } = "";
    }

    class DcfApiTest
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "http://localhost:8080/api/regions");
            var content = new StringContent("{ \"name\": \"North East Region\" }", null, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var result = response.Content.ReadAsStringAsync().Result;

            Region? region = JsonSerializer.Deserialize<Region>(result);

            if (region is not null)
            {
                System.Console.WriteLine(region.id + "," + region.name);
            }

        }
    }

}
