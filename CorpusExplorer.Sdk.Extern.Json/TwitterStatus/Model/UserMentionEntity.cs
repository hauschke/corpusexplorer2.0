﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CorpusExplorer.Sdk.Extern.Json.TwitterStatus.Model
{

    public class UserMentionEntity
    {

        [JsonProperty("Id")]
        public ulong Id { get; set; }

        [JsonProperty("ScreenName")]
        public string ScreenName { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Start")]
        public ulong Start { get; set; }

        [JsonProperty("End")]
        public ulong End { get; set; }
    }

}
