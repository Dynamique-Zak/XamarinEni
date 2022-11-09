using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EniDemo.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Tweet
    {
        public String Identifiant { get; set; }

        [JsonProperty]
        public String DateCreation { get; set; }

        [JsonProperty]
        public String Message { get; set; }

        public String Pseudo { get; set; }
        public String Password { get; set; }
    }
}
