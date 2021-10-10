using System;
using System.Collections.Generic;
using System.Linq;
using Assignment.Models;
using Microsoft.Win32.SafeHandles;

namespace Assignment.Data.Impl
{
    public class InMemoryUserService : IUsersService
    {
        private List<Users> users;

        public InMemoryUserService()
        {
            users = new[]
            {
                new Users
                {
                    UserName = "admin",
                    Password = "123456",
                    IsAdmin = true
                },
                new Users
                {
                    UserName = "student",
                    Password = "654321",
                    IsAdmin = true
                }
            }.ToList();
        }


        public Users ValidateUsers(string userName, string Password)
        {
            // Find user in the array
            Users first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null)
            {
                throw new Exception("User not found");
            }
            if (!first.Password.Equals(Password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}