using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlexaAPI.Response
{
    public class HintDirective : IDirective
    {
        [JsonProperty("type")]
        public string Type { get { return "Hint"; } }

        [JsonProperty("hint")]
        public IText Hint { get; set; }
    }
}