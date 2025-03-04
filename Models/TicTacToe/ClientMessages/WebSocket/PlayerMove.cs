﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alexm_app.Models.TicTacToe.ClientMessages.WebSocket
{
    public class PlayerMove: ClientMessage
    {
        [JsonProperty("message_type")]
        public string MessageType { get; set; } = "PlayerMove";
        [JsonProperty("x")]
        public int X { get; set; }
        [JsonProperty("y")]
        public int Y { get; set; }
    }
}
