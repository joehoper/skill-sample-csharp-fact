using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlexaAPI.Response
{
    public class RenderTemplateDirective : IDirective
    {
        [JsonProperty("type")]
        public string Type { get { return "Display.RenderTemplate"; } }

        [JsonProperty("template")]
        public Template Template { get; set; }
    }
}