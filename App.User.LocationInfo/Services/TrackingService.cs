/*
TrackingService.cs
30/05/2019 14:53:23
Kodjo Laurent Egbakou
*/

using App.User.LocationInfo.Constants;
using App.User.LocationInfo.Models;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Diagnostics;
using System.Threading.Tasks;

namespace App.User.LocationInfo.Services
{
    /// <summary>
    /// Defines the <see cref="TrackingService" />
    /// </summary>
    public class TrackingService
    {
        /// <summary>
        /// Get current user's IP Adress.
        /// </summary>
        /// <returns>User's IP Adres.</returns>
        public static async Task<string> GetUserIPAdressAsync()
        {
            var client = new RestClient(APIResources.IpifyApi);
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteGetTaskAsync(request);
            JObject jsonObject = JObject.Parse(response.Content);
            return (string)jsonObject["ip"];
        }
    }
}
