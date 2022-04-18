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
    public class SeedDiscountData : IEntityTypeConfiguration<DiscountTypes>
    {
        public void Configure(EntityTypeBuilder<DiscountTypes> builder)
        {
            builder.HasData
            (
                new DiscountTypes
                {
                    Id = 1,
                    Name = "Affiliate Discount",
                    Type = "Affiliate",
                    Rate = 10,
                    IsRatePercentage = true
                },
                new DiscountTypes
                {
                    Id = 2,
                    Name = "Employee Discount",
                    Type = "Employee",
                    Rate = 30,
                    IsRatePercentage = true
                },
                new DiscountTypes
                {
                    Id = 3,
                    Name = "Loyal Customer Discount",
                    Type = "Customer",
                    Rate = 5,
                    IsRatePercentage = true
                },
                new DiscountTypes
                {
                    Id = 4,
                    Name = "Price Discount",
                    Type = "Price",
                    Rate = 5,
                    IsRatePercentage = false
                }
            );
        }
    }
}
