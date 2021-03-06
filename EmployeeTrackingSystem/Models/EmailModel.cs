﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTrackingSystem.Models
{
    public class EmailModel
    {
        public string From { get; set; }

        public string To { get; set; }

        public string Cc { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public string Sent { get; set; }
    }
}