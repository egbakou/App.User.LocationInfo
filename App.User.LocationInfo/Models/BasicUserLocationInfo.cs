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
        /// Gets or sets the Ip
        /// Ip adress
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// Gets or sets the City
        /// City name
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the Region
        /// Region name
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the RegionCode
        /// Region code
        /// </summary>
        public string RegionCode { get; set; }

        /// <summary>
        /// Gets or sets the Country
        /// Country code
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the CountryName
        /// Country name
        /// </summary>
        public string CountryName { get; set; }

        /// <summary>
        /// Gets or sets the ContinentCode
        /// Continent code
        /// </summary>
        public string ContinentCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether InEU
        /// Current user's country is in Eiuroppean Union ?
        /// </summary>
        public bool InEU { get; set; }

        /// <summary>
        /// Gets or sets the Postal
        /// Postal code
        /// </summary>
        public string Postal { get; set; }

        /// <summary>
        /// Gets or sets the Location
        /// User location: Latitude and Latitude
        /// </summary>
        public GeoPosition Location { get; set; }

        /// <summary>
        /// Gets or sets the Timezone
        /// Country TimeZone
        /// </summary>
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or sets the UtcOffset
        /// UTC Offset
        /// </summary>
        public string UtcOffset { get; set; }

        /// <summary>
        /// Gets or sets the CountryCallingCode
        /// Country Calling Code
        /// </summary>
        public string CountryCallingCode { get; set; }

        /// <summary>
        /// Gets or sets the Currency
        /// country Currency
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the Languages
        /// Country languages
        /// </summary>
        public List<string> Languages { get; set; }

        /// <summary>
        /// Gets or sets the Asn
        /// ASN
        /// </summary>
        public string Asn { get; set; }

        /// <summary>
        /// Gets or sets the Org
        /// Internet Service Provider
        /// </summary>
        public string Org { get; set; }
    }
}
