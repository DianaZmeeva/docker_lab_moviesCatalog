﻿using System;
using System.ComponentModel.DataAnnotations;
using MovieCatalog.API.Models.Data;

namespace MovieCatalog.API.Models.Api.Users
{
    public class ProfileModel
    {
        public string NickName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string AvatarLink { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }
    }
}