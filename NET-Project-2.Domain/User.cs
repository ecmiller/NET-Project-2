﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Project_2.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Plan> Plan { get; set; } = new List<Plan>();
        public List<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>();
        public List<Device> Devices { get; set; } = new List<Device>();
    }
}