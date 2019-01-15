using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace AlexaAPI.Response
{
    public interface IText
    {
        string Type { get; }
        string Text { get; set; }
    }
}