﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlexaBase.Models
{
    public class alexaQueryIntent
    {
        public string name { get; set; }
        public alexaQueryIntentSlot slots { get; set; }
    }
}