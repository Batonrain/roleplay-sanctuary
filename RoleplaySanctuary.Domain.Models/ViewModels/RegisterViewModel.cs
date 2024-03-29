﻿using System.ComponentModel.DataAnnotations;

namespace RoleplaySanctuary.Domain.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Login is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Login is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
