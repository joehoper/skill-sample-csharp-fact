using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace AlexaAPI.Response
{
    public class Image
    {
        [JsonProperty("contentDescription")]
        public string ContentDescription { get; set; }

        [JsonProperty("sources")]
        public IList<ImageSource> Sources { get; set; } = new List<ImageSource>();
    }
}