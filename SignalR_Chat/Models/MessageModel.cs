using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace SignalR_Chat.Models
{
    public class MessageModel
    {
        // We declare message as lowercase with JsonProperty to sync the client and server models
        [JsonProperty("message")]
        public string Message { get; set; }

        // We don't want the client to get the "LastUpdatedBy" property
        [JsonIgnore]
        public string LastUpdatedBy { get; set; }
    }
}