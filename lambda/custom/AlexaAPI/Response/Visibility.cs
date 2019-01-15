using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AlexaAPI.Response
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Visibility
    {
        /// <summary>
        /// Shown on screen (default)
        /// </summary>
        VISIBLE,

        /// <summary>
        /// Not shown on screen
        /// </summary>
        HIDDEN,
    }
}