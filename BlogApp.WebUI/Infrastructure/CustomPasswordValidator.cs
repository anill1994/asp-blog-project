﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.WebUI.Models;
using Microsoft.AspNetCore.Identity;

namespace BlogApp.WebUI.Infrastructure
{
    public class CustomPasswordValidator : IPasswordValidator<ApplicationUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<ApplicationUser> manager, ApplicationUser user, string password)
        {
            List<IdentityError> errors = new List<IdentityError>();
            if (password.ToLower().Contains(user.UserName.ToLower()))
            {
                errors.Add(new IdentityError()
                {
                    Code = "PasswordContainsUserName",
                    Description = "Password cannot contain username"
                });
            }
            if (password.Contains("123"))
            {
                errors.Add(new IdentityError()
                {
                    Code = "PasswordContainsSequence",
                    Description = "Password cannot caontain numeric sequence"
                });
            }

            return Task.FromResult(errors.Count == 0
                ? IdentityResult.Success
                : IdentityResult.Failed(errors.ToArray()));
        }
    }
}
