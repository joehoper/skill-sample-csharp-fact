using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace AlexaAPI.Response
{
    public class ListItem
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public Image Image { get; set; }

        [JsonProperty("textContent")]
        public TextContent TextContent { get; set; }
    }
}