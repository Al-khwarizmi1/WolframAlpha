﻿using Newtonsoft.Json;

namespace Wolfram.Alpha.Models
{
    public class Error
    {
        public int Code { get; set; }
        [JsonProperty("msg")]
        public string Message { get; set; }
    }
}
