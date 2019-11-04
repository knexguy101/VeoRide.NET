using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace VeoRide.NET.Models
{
    public class Ride
    {
        public string ID { get; set; }
        public string VehicleNumber { get; set; }
        public string VehicleType { get; set; }
        public string LockStatus { get; set; }
        public Coordinate Coordinates { get; set; }

        public static Ride LoadRide(string RawData)
        {
            try
            {
                JObject temp = JObject.Parse(RawData);
                return new Ride
                {
                    ID = temp["id"].Value<string>(),
                    VehicleNumber = temp["vehicleNumber"].Value<string>(),
                    VehicleType = temp["vehicleType"].Value<string>(),
                    LockStatus = temp["lockStatus"].Value<string>(),
                    Coordinates = new Coordinate(temp["location"]["lat"].Value<string>(), temp["location"]["lng"].Value<string>())
                };
            }
            catch
            {
                return null;
            }
        }

        public string GetFormattedDataString()
        {
            return $"ID: {ID} VehicleID: {VehicleNumber} Type: {VehicleType} LockStatus: {LockStatus}";
        }

        public string GetWebhookBody()
        {
            string x = $"{Environment.NewLine}";
            x += $"**[Lock Status]** {this.LockStatus}{Environment.NewLine}";
            x += $"**[ID]** {this.ID}{Environment.NewLine}";
            x += $"**[Type]** {this.VehicleType}{Environment.NewLine}";
            x += $"**[Coords]** {this.Coordinates.Lat + " " + this.Coordinates.Long}{Environment.NewLine}{Environment.NewLine}";
            x += $"[Coords Link](http://google.com/maps/place/{this.Coordinates.Lat},{this.Coordinates.Long})";
            return x;
        }
    }
}
