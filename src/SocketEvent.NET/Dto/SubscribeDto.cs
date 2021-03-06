﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SocketEvent.Dto
{
    /// <summary>
    /// DTO used when subscribing an event.
    /// </summary>
    class SubscribeDto : BaseCommunicateDto
    {
        /// <summary>
        /// Event to subscribe.
        /// </summary>
        [JsonProperty("event")]
        public string Event { get; set; }
    }
}
