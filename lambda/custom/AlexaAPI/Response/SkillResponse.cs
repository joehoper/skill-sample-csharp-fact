using System.Collections.Generic;
using Newtonsoft.Json;

namespace AlexaAPI.Response
{
    public class SkillResponse
    {
        [JsonProperty("version"), JsonRequired]
        public string Version { get { return "1.0"; } }

        [JsonProperty("sessionAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> SessionAttributes { get; set; }

        [JsonProperty("response")]
        public ResponseBody Response { get; set; }
    }
}