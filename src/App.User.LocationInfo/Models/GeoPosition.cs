﻿/*
GeoPosition.cs
03/06/2019 15:29:37
Kodjo Laurent Egbakou
*/

namespace App.User.LocationInfo.Models
{
    /// <summary>
    /// Represents GPS Coordinates object.
    /// </summary>
    public class GeoPosition
    {
        /// <summary>
        /// Gets the Latitude.
        /// </summary>
        public double Latitude { get; }

        /// <summary>
        /// Gets the Longitude.
        /// </summary>
        public double Longitude { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoPosition"/> class.
        /// </summary>
        /// <param name="Lat">The Lat<see cref="double"/>Latitude</param>
        /// <param name="Lng">The Lng<see cref="double"/>Longitude</param>
        public GeoPosition(double Lat, double Lng)
        {
            Latitude = Lat;
            Longitude = Lng;
        }
    }
}
