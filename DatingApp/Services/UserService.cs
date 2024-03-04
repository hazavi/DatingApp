﻿using System.Drawing.Printing;

namespace DatingApp.Services
{
    public class UserService
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public bool IsLoggedIn { get; set; }


    }
}
