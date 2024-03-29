﻿using System.ComponentModel.DataAnnotations;

namespace Movie.INFARSTRUTURE.Models.UserModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
}
