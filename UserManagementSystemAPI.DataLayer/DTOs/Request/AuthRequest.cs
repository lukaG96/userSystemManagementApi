﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementSystemAPI.DataLayer.DTOs.Request
{
    public class AuthRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
