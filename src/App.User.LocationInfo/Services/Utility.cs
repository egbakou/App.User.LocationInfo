/*
Utility.cs
30/05/2019 14:49:39
Kodjo Laurent Egbakou
*/

using App.User.LocationInfo.Models;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace App.User.LocationInfo.Services
{
    /// <summary>
    /// Defines <see cref="Utility" /> class.
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Convert JObject(JSON object) to BasicUserLocationInfo.
        /// </summary>
        /// <param name="jsonObject">The jsonObject<see cref="JObject"/></param>
        /// <returns>The <see cref="BasicUserLocationInfo"/>Basic information about the user's location.</returns>
        public static BasicUserLocationInfo JObjectToBasicUserLocationInfo(JObject jsonObject)
        {
            BasicUserLocationInfo result = null;
            if (jsonObject != null)
            {
                result = new BasicUserLocationInfo
                {
                    Ip = (string)jsonObject["ip"],
                    City = (string)jsonObject["city"],
                    Region = (string)jsonObject["region"],
                    RegionCode = (string)jsonObject["region_code"],
                    Country = (string)jsonObject["country"],
                    CountryName = (string)jsonObject["country_name"],
                    ContinentCode = (string)jsonObject["continent_code"],
                    InEU = (bool)jsonObject["in_eu"],
                    Location = new GeoPosition((double)jsonObject["latitude"], (double)jsonObject["longitude"]),
                    Timezone = (string)jsonObject["timezone"],
                    UtcOffset = (string)jsonObject["utc_offset"],
                    CountryCallingCode = (string)jsonObject["country_calling_code"],
                    Currency = (string)jsonObject["currency"],
                    Languages = StringLanguagesToList(jsonObject),
                    Asn = (string)jsonObject["asn"],
                    Org = (string)jsonObject["org"]
                };
            }

            return result;
        }


        /// <summary>
        /// Get languages as string from JObject and convert it to List.
        /// </summary>
        /// <param name="jsonObject">JObject</param>
        /// <returns>The <see cref="List{String}"/>Languages</returns>
        public static List<string> StringLanguagesToList(JObject jsonObject)
        {
            List<string> languages = null;
            string sl = (string)jsonObject["languages"];
            if (sl != null)
            {

                languages = sl.Contains(",")
                    ? sl.Split(',').ToList()
                    : new List<string> { sl };
            }
            return languages;
        }
    }
}
