using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace AlexaAPI.Response
{
    public abstract class ListTemplate : Template
    {
        [JsonProperty("listItems")]
        public IList<ListItem> ListItems { get; set; } = new List<ListItem>();
    }
}