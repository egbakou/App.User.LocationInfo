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
        /// Gets the URL of the Country flag image
        /// </summary>
        public string CountryFlagUrl { get; }

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
