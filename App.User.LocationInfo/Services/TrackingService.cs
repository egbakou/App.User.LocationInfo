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
    /// Defines the <see cref="TrackingService" />.
    /// </summary>
    public class TrackingService
    {
        /// <summary>
        /// Get current user's IP Address.
        /// </summary>
        /// <returns>User's IP Address.</returns>
        public static async Task<string> GetUserIPAdressAsync()
        {
            var client = new RestClient(APIResources.IPIFY_API);
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
            var request = new RestRequest(APIResources.IPAPI, Method.GET, DataFormat.Json);
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
            var request = new RestRequest(APIResources.IPAPI, Method.GET, DataFormat.Json);
            IRestResponse response = await client.ExecuteGetTaskAsync(request);
            JObject jsonObject = JObject.Parse(response.Content);
            return (string)jsonObject["country_name"];
        }


        /// <summary>
        /// Get informations about the user's location without URL of the country flag.
        /// </summary>
        /// <returns>An instance of <see cref="BasicUserLocationInfo"/></returns>
        public static async Task<BasicUserLocationInfo> GetBasicLocatioInfoAsync()
        {
            var client = new RestClient();
            var request = new RestRequest(APIResources.IPAPI, Method.GET, DataFormat.Json);
            IRestResponse response = await client.ExecuteGetTaskAsync(request);
            JObject jsonObject = JObject.Parse(response.Content);
            return Utility.JObjectToBasicUserLocationInfo(jsonObject);
        }


        /// <summary>
        /// Get informations about the user's location including URL of the country flag.
        /// </summary>
        /// <returns>The <see cref="Task{UserLocationInfo}"/></returns>
        public static async Task<UserLocationInfo> GetLocationInfoAsync()
        {
            BasicUserLocationInfo ipApiResult = await GetBasicLocatioInfoAsync();
            var client = new RestClient();
            var request = new RestRequest(APIResources.RESTCOUNTRIES_API + ipApiResult.CountryName, Method.GET, DataFormat.Json);
            IRestResponse response = await client.ExecuteGetTaskAsync(request);
            Debug.WriteLine(response.Content);
            JArray jsonArray = JArray.Parse(response.Content.ToString());
            var flagUrl = (string)jsonArray[0]["flag"];
            return new UserLocationInfo(ipApiResult, flagUrl);
        }
    }
}
