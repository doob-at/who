﻿using System.ComponentModel.DataAnnotations;

namespace doob.Who.Controllers.FirstSetup
{
    public class FirstSetupModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }


        public string RedirectUri { get; set; }
    }
}
