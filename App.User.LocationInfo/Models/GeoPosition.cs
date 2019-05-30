using System;
using System.Collections.Generic;
using System.Text;

namespace App.User.LocationInfo.Models
{
    public class GeoPosition
    {
        public double Latitude { get; }
        public double Longitude { get; }

        public GeoPosition(double Lat, double Lng)
        {
            Latitude = Lat;
            Longitude = Lng;
        }
    }
}
