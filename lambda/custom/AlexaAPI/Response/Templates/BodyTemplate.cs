using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace AlexaAPI.Response
{
    public abstract class BodyTemplate : Template
    {
        [JsonProperty("textContent")]
        public TextContent TextContent { get; set; }
    }
}