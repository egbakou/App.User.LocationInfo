/*
UserLocationInfo.cs
30/05/2019 14:26:48
Kodjo Laurent Egbakou
*/

using System.Collections.Generic;

namespace App.User.LocationInfo.Models
{
    /// <summary>
    /// Defines the <see cref="UserLocationInfo" />
    /// </summary>
    public class UserLocationInfo
    {
        /// <summary>
        /// Gets or sets the Ip adress
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// Gets or sets the City name
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the Region name
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the Region code
        /// </summary>
        public string RegionCode { get; set; }

        /// <summary>
        /// Gets or sets the Country code
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the Country name
        /// </summary>
        public string CountryName { get; set; }

        /// <summary>
        /// Gets or sets the URL of the Country flag image
        /// </summary>
        public string CountryFlagUrl { get; set; }

        /// <summary>
        /// Gets or sets the Continent code
        /// </summary>
        public string ContinentCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether current user's country is in European Union
        /// </summary>
        public bool InEU { get; set; }

        /// <summary>
        /// Gets or sets Postal code
        /// </summary>
        public string Postal { get; set; }

        /// <summary>
        /// Gets or sets user's location: Latitude and Longitude
        /// </summary>
        public GeoPosition Location { get; set; }

        /// <summary>
        /// Gets or sets the Country TimeZone
        /// </summary>
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or sets the UTC Offset
        /// </summary>
        public string UtcOffset { get; set; }

        /// <summary>
        /// Gets or sets the Country Calling Code
        /// </summary>
        public string CountryCallingCode { get; set; }

        /// <summary>
        /// Gets or sets the Currency of the country
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the country languages
        /// </summary>
        public List<string> Languages { get; set; }

        /// <summary>
        /// Gets or sets the ASN
        /// </summary>
        public string Asn { get; set; }

        /// <summary>
        /// Gets or sets the Internet Service Provider
        /// </summary>
        public string Org { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserLocationInfo"/> class.
        /// </summary>
        /// <param name="ipApiResult">The ipApiResult<see cref="BasicUserLocationInfo"/></param>
        /// <param name="flagUrl">The flagUrl<see cref="string"/></param>
        public UserLocationInfo(BasicUserLocationInfo ipApiResult, string flagUrl)
        {
            this.Ip = ipApiResult.Ip;
            this.City = ipApiResult.City;
            this.Region = ipApiResult.Region;
            this.RegionCode = ipApiResult.RegionCode;
            this.Country = ipApiResult.Country;
            this.CountryName = ipApiResult.CountryName;
            this.CountryFlagUrl = flagUrl;
            this.ContinentCode = ipApiResult.ContinentCode;
            this.InEU = ipApiResult.InEU;
            this.Postal = ipApiResult.Postal;
            this.Location = ipApiResult.Location;
            this.Timezone = ipApiResult.Timezone;
            this.UtcOffset = ipApiResult.UtcOffset;
            this.CountryCallingCode = ipApiResult.CountryCallingCode;
            this.Currency = ipApiResult.Currency;
            this.Languages = ipApiResult.Languages;
            this.Asn = ipApiResult.Asn;
            this.Org = ipApiResult.Org;
        }
    }
}
