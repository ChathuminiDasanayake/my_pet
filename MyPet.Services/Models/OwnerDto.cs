﻿using MyPet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPet.Services.Models
{
    public class OwnerDto
    {
        public int Id { get; set; }
       
        public string FullName { get; set; }
        
        public string PhoneNumber { get; set; }
     
        public string Address { get; set; }
        

    }
}
