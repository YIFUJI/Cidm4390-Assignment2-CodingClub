using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CodingClub.Models
{
    public class Client : PersonInfo
    {
        [Display(Name = "Clinet Name")]        
        public int ClientID { get; set; }
        public string PaymentMethod { get; set; }
    }
}