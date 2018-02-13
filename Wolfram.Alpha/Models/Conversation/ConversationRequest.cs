﻿using System.Device.Location;

namespace Wolfram.Alpha.Models.Conversation
{
    public class ConversationRequest
    {
        public string I { get; set; }
        public GeoCoordinate GeoLocation { get; set; }
        public string Ip { get; set; }
        public string Units { get; set; }
        public string S { get; set; }
        public string Conversationid { get; set; }
        public string Host { get; set; }
    }
}
