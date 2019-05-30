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


        /// <summary>
        /// Get current user's country code.
        /// </summary>
        /// <returns>Current user's country code.</returns>
        public static async Task<string> GetUserCountryCodeAsync()
        {
            var client = new RestClient();
            var request = new RestRequest(APIResources.IpApi, Method.GET, DataFormat.Json);
            IRestResponse response = await client.ExecuteGetTaskAsync(request);
            JObject jsonObject = JObject.Parse(response.Content);
            return (string)jsonObject["country"];
        }


        /// <summary>
        /// Get current user's country name.
        /// </summary>
        /// <returns>Current user's country name.</returns>
        public static async Task<string> GetUserCountryNameAsync()
        {
            var client = new RestClient();
            var request = new RestRequest(APIResources.IpApi, Method.GET, DataFormat.Json);
            IRestResponse response = await client.ExecuteGetTaskAsync(request);
            JObject jsonObject = JObject.Parse(response.Content);
            return (string)jsonObject["country_name"];
        }


        /// <summary>
        /// Get informations about the user's location without URL of the country flag.
        /// </summary>
        /// <returns>An instance of <see cref="IpApiResult"/></returns>
        public static async Task<BasicUserLocationInfo> GetBasicLocatioInfoAsync()
        {
            var client = new RestClient();
            var request = new RestRequest(APIResources.IpApi, Method.GET, DataFormat.Json);
            IRestResponse response = await client.ExecuteGetTaskAsync(request);
            JObject jsonObject = JObject.Parse(response.Content);
            return Utility.JsonObjectToIpApiResult(jsonObject);
        }
    }
}
