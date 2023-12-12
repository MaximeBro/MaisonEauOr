﻿namespace MaisonEauOr.Models
{
    public class UserSession
    {
        public Guid Identifier { get; set; }
        public string UserName { get; set; }
        public UserRole Role { get; set; }
    }

    public enum UserRole
    {
        Guest,
        Client,
        Admin
    }
}
