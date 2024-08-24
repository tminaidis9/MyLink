﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyLink.Data.Access;
using MyLink.Models;

namespace MyLink.Data.Initialize
{
    public class InitializerDb
    {
        public static async Task Initialize(ApplicationDbContext db, UserManager<User> users)
        {
            // Create Users
            if (!users.Users.Any())
            {
                //Test dimitris rammos user
                User user = new User()
                {
                    FirstName = "Dimitris",
                    LastName = "Rammos",
                    PhoneNumber = "1234567890",
                    UserName = "jrammos",
                    Email = "jrammos@outlook.com.gr",
                    PictureURL = "rammos.com"
                };

                var result = await users.CreateAsync(user, "1234@Password");
                await users.AddToRoleAsync(user, "Admin");

                await db.SaveChangesAsync();
            }
        }
    }
}
