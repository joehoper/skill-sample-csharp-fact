using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace AlexaAPI.Response
{
    public class TextContent
    {
        [JsonProperty("primaryText", NullValueHandling = NullValueHandling.Ignore)]
        public IText PrimaryText { get; set; }

        [JsonProperty("secondaryText", NullValueHandling = NullValueHandling.Ignore)]
        public IText SecondaryText { get; set; }

        [JsonProperty("tertiaryText", NullValueHandling = NullValueHandling.Ignore)]
        public IText TertiaryText { get; set; }
    }
}