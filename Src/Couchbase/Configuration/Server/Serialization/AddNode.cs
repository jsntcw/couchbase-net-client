﻿using Newtonsoft.Json;

namespace Couchbase.Configuration.Server.Serialization
{
    internal sealed class AddNode
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
}