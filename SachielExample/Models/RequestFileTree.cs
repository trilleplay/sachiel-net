﻿using ProtoBuf;
using Sachiel;
using Sachiel.Messages;
using SachielExample.Handlers;

namespace SachielExample.Models
{
    [ProtoContract]
    [SachielEndpoint(Name = "RequestFileTree", Handler = typeof(FilePacketHandler))]
    public class RequestFileTree : Message
    {
        [ProtoMember(1)]
        public string Path { get; set; }
    }
}