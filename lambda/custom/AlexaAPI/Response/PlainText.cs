using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace AlexaAPI.Response
{
    public class PlainText : IText
    {
        [JsonProperty("type")]
        public string Type { get { return "PlainText"; } }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}