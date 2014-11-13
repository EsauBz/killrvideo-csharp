﻿using System;

namespace KillrVideo.UserManagement.Api.Commands
{
    /// <summary>
    /// DTO for creating a new user account.
    /// </summary>
    public class CreateUser
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}