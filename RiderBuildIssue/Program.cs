using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace RiderBuildIssue
{
    public class Program
    {
        public static void Main()
        {
            var ipAddress = GetIpAddressAsync().Result;
            Console.WriteLine($"Your IP address is {ipAddress.Ip}");
        }

        public static async Task<IpAddress> GetIpAddressAsync()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("http://ip.jsontest.com");
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsAsync<IpAddress>();
            }
        }
    }

    public class IpAddress
    {
        public string Ip { get; set; }
    }
}