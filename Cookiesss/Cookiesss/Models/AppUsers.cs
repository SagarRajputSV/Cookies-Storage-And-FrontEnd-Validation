﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Cookiesss.Models
{
    public class AppUsers
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}