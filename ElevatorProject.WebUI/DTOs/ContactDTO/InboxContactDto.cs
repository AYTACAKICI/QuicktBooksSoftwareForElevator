﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevatorProject.WebUI.DTOs.ContactDTO
{
    public class InboxContactDto
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
