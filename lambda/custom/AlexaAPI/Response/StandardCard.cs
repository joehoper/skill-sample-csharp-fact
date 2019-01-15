using System.Collections.Generic;
using Newtonsoft.Json;

namespace AlexaAPI.Response
{
    public class StandardCard : ICard
    {
        [JsonRequired]
        [JsonProperty("type")]
        public string Type { get { return "Standard"; } }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public CardImage Image { get; set; }
    }
}