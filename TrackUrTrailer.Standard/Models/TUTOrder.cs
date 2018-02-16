//Quicktype.io-generated
using System;
using System.Net;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace TrackUrTrailer.Standard
{

    public partial class TUTOrder
    {
        [JsonProperty("ID")]
        public long Id { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("Product")]
        public string Product { get; set; }

        [JsonProperty("Quantity")]
        public long Quantity { get; set; }

        [JsonProperty("ScheduledDeliveryDate")]
        public System.DateTime ScheduledDeliveryDate { get; set; }

        [JsonProperty("DeliveryAddress")]
        public DeliveryAddress DeliveryAddress { get; set; }

        [JsonProperty("DeliveryVehicle")]
        public DeliveryVehicle DeliveryVehicle { get; set; }
    }

    public partial class DeliveryAddress
    {
        [JsonProperty("Line1")]
        public string Line1 { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("State")]
        public string State { get; set; }

        [JsonProperty("Zipcode")]
        public string Zipcode { get; set; }
    }

    public partial class DeliveryVehicle
    {
        [JsonProperty("CurrentLocation")]
        public CurrentLocation CurrentLocation { get; set; }
    }

    public partial class CurrentLocation
    {
        [JsonProperty("Latitude")]
        public double Latitude { get; set; }

        [JsonProperty("Longitude")]
        public double Longitude { get; set; }
    }

    public partial class TUTOrder
    {
        public static TUTOrder FromJson(string json) => JsonConvert.DeserializeObject<TUTOrder>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this TUTOrder self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}
