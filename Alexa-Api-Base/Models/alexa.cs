﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReziAlexa;

namespace ReziAlexa.Models
{
    public class alexa
    {
        public string version { get; set; }
        public AlexaResponse response { get; set; }
        public object sessionAttributes { get; set; }
    }
}