/*
BasicUserLocationInfo.cs
30/05/2019 13:50:13
Kodjo Laurent Egbakou
*/

using System.Collections.Generic;

namespace App.User.LocationInfo.Models
{
    /// <summary>
    /// Defines the <see cref="BasicUserLocationInfo" />
    /// </summary>
    public class BasicUserLocationInfo
    {
        /// <summary>
        /// Gets the Ip adress
        /// </summary>
        public string Ip { get; }

        /// <summary>
        /// Gets the City name
        /// </summary>
        public string City { get; }

        /// <summary>
        /// Gets the Region name
        /// </summary>
        public string Region { get; }

        /// <summary>
        /// Gets the Region code
        /// </summary>
        public string RegionCode { get; }

        /// <summary>
        /// Gets the Country code
        /// </summary>
        public string Country { get; }

        /// <summary>
        /// Gets the Country name
        /// </summary>
        public string CountryName { get; }

        /// <summary>
        /// Gets the Continent code
        /// </summary>
        public string ContinentCode { get; }

        /// <summary>
        /// Gets a value indicating whether current user's country is in European Union
        /// </summary>
        public bool InEU { get; }

        /// <summary>
        /// Gets Postal code
        /// </summary>
        public string Postal { get; }

        /// <summary>
        /// Gets user's location: Latitude and Latitude
        /// </summary>
        public GeoPosition Location { get; }

        /// <summary>
        /// Gets the Country TimeZone
        /// </summary>
        public string Timezone { get; }

        /// <summary>
        /// Gets the UTC Offset
        /// </summary>
        public string UtcOffset { get; }

        /// <summary>
        /// Gets the Country Calling Code
        /// </summary>
        public string CountryCallingCode { get; }

        /// <summary>
        /// Gets the Currency of the country
        /// </summary>
        public string Currency { get; }

        /// <summary>
        /// Gets the country languages
        /// </summary>
        public List<string> Languages { get; }

        /// <summary>
        /// Gets the ASN
        /// </summary>
        public string Asn { get; }

        /// <summary>
        /// Gets the Internet Service Provider
        /// </summary>
        public string Org { get; }
    }
}
