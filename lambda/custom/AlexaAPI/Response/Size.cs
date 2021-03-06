﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AlexaAPI.Response
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Size
    {
        /// <summary>
        /// Displayed within extra small containers	480 x 320
        /// </summary>
        X_SMALL,

        /// <summary>
        /// Displayed within small containers	720 x 480
        /// </summary>
        SMALL,

        /// <summary>
        /// Displayed within medium containers	960 x 640
        /// </summary>
        MEDIUM,

        /// <summary>
        /// Displayed within large containers	1200 x 800
        /// </summary>
        LARGE,

        /// <summary>
        /// Displayed within extra large containers	1920 x 1280
        /// </summary>
        X_LARGE,
    }
}