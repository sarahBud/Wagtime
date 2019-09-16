﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WagtimeTest.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string DogName { get; set; }
        public string DogBreed { get; set; }
        public string DogDescription { get; set; }
        public string PhotoPath { get; set; }
    }
}
