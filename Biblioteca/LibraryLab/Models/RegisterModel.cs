﻿using System.ComponentModel.DataAnnotations;

namespace LibraryLab.Models

{
    public class RegisterModel
    {
        [Required]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }


        [Required]
        [Display(Name = "Username")]
        public string? Username { get; set; }


        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Required]
        public string? Role { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string? Password { get; set; }

    }
}
