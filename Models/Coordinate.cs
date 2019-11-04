using System;
using System.Collections.Generic;
using System.Text;

namespace VeoRide.NET.Models
{
    public class Coordinate
    {
        public string Lat { get; set; }
        public string Long { get; set; }

        public Coordinate(string Lat, string Long)
        {
            this.Lat = Lat;
            this.Long = Long;
        }
    }
}
