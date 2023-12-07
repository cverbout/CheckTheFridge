﻿using System.ComponentModel.DataAnnotations;

namespace CheckTheFridge.Models
{
    public class UserRegisterRequest
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required] 
        public string LastName { get; set; } = string.Empty;
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required, MinLength(6)]
        public string Password { get; set; } = string.Empty;
    }
}

