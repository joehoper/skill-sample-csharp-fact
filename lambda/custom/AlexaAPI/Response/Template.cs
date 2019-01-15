using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace AlexaAPI.Response
{
    public abstract class Template
    {
        [JsonProperty("type")]
        public string Type { get { return GetType().Name; } }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("backButton")]
        public Visibility BackButton { get; set; }

        [JsonProperty("backgroundImage", NullValueHandling = NullValueHandling.Ignore)]
        public Image BackgroundImage { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}