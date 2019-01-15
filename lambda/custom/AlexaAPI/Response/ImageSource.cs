using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace AlexaAPI.Response
{
    public class ImageSource
    {
        [JsonProperty("url", Required = Required.Always)]
        public string Url { get; set; }

        [JsonProperty("size", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Size Size { get; set; }

        [JsonProperty("widthPixels", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? WidthPixels { get; set; }

        [JsonProperty("heightPixels", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? HeightPixels { get; set; }
    }
}