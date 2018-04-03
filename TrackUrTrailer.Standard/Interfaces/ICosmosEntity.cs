using System;
using Newtonsoft.Json;

namespace TrackUrTrailer.Standard
{
    public interface ICosmosEntity
    {
        [JsonProperty(PropertyName = "id")]
        string id { get; set; }

        [JsonProperty("_etag")]
        string _etag { get; set; }

        [JsonProperty("_rid")]
        string _rid { get; set; }

        [JsonProperty("_self")]
        string _self { get; set; }
    }
}
