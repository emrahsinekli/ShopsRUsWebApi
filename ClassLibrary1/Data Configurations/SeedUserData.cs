using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopsRUs.Domains;
using ShopsRUs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Data.Configurations
{
    public class SeedUserData : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasData
            (
                new Users
                {
                    UserId = 1,
                    Name = "Sheldon",
                    Surname = "Cooper",
                    Email = "user1@email.com",
                    PhoneNumber = "123456789",
                    UserType = "Customer",
                    CreatedDate = DateTime.Now.AddYears(-3)
                },
                new Users
                {
                    UserId = 2,
                    Name = "Leonard",
                    Surname = "Hoffsteder",
                    Email = "user2@email.com",
                    PhoneNumber = "12345678910",
                    UserType = "Customer",
                    CreatedDate = DateTime.Now.AddMonths(-3)
                },
                new Users
                {
                    UserId = 3,
                    Name = "Penny",
                    Surname = "Jackson",
                    Email = "user3@email.com",
                    PhoneNumber = "123456789",
                    UserType = "Affiliate",
                    CreatedDate = DateTime.Now.AddYears(-1)
                },
                new Users
                {
                    UserId = 4,
                    Name = "Amy",
                    Surname = "Fowler",
                    Email = "user4@email.com",
                    PhoneNumber = "123456789",
                    UserType = "Employee",
                    CreatedDate = DateTime.Now.AddYears(-5)
                },
                new Users
                {
                    UserId = 5,
                    Name = "Raj", 
                    Surname = "Koothrappali",
                    Email = "user5@email.com",
                    PhoneNumber = "123456789",
                    UserType = "Employee",
                    CreatedDate = DateTime.Now.AddYears(-3)
                }
            );
        }
    }
}
