namespace ClassLibrary3.Migrations
{
    using ShopsRUs.Domains;
    using ShopsRUs.Domains.Entities;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ShopsRUs.DAL.ApiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShopsRUs.DAL.ApiContext context)
        {
            ICollection<DiscountTypes> discountTypes = new List<DiscountTypes>() {
                new DiscountTypes {Id=1, Name= "Affiliate Discount",Type= "Affiliate",Rate=10,IsRatePercentage=true},
                new DiscountTypes {Id=2, Name = "Employee Discount", Type = "Employee", Rate = 30, IsRatePercentage = true },
                new DiscountTypes {Id=3, Name = "Loyal Customer Discount", Type = "Customer", Rate = 5, IsRatePercentage = true },
                new DiscountTypes {Id=4, Name = "Price Discount", Type = "Price", Rate = 5, IsRatePercentage = false }
            };


            foreach (var i in discountTypes)
            {
                context.DiscountTypes.Add(i);
            }
            context.SaveChanges();

            ICollection<Category> categories = new List<Category>()
            {
                new Category {Id=1,Name ="Groceries"},
                new Category {Id=2,Name ="Fashion"},
                new Category {Id=3,Name ="Electronic"},
                new Category {Id=4,Name ="Other"}
            };
            foreach (var i in categories)
            {
                context.Categories.Add(i);
            }
            context.SaveChanges();
            ICollection<Product> products = new List<Product>()
            {
                new Product { Id=1,ProductName="Aubergine", CategoriesId =1, ProductPrice= 10m, DerivedProductCost=8m },
                new Product { Id=2,ProductName="Pepper", CategoriesId =1, ProductPrice= 12m, DerivedProductCost=10m },
                new Product { Id=3,ProductName="Trousers 1", CategoriesId =2, ProductPrice= 80m, DerivedProductCost=70m },
                new Product { Id=4,ProductName="Computer 1", CategoriesId =3, ProductPrice= 1000m, DerivedProductCost=900m },
                new Product { Id=5,ProductName="Book 1", CategoriesId =4, ProductPrice= 20m, DerivedProductCost=18m },
                new Product { Id=6,ProductName="Sweater 1", CategoriesId =2, ProductPrice= 70m, DerivedProductCost=60m },
                new Product { Id=7,ProductName="Phone 1", CategoriesId =3, ProductPrice= 920m, DerivedProductCost=900m },
                new Product { Id=8,ProductName="Pencil 1", CategoriesId =4, ProductPrice= 5m, DerivedProductCost=4m },
                new Product { Id=9,ProductName="Glass 1 ", CategoriesId =4, ProductPrice= 16m, DerivedProductCost=14m }
            };
            foreach (var i in products)
            {
                context.Products.Add(i);
            }
            context.SaveChanges();
            ICollection<CustomerType> customerTypes = new List<CustomerType>()
            {
                new CustomerType {Id=1,TypeName="Employee", TypeCode="emp" },
                new CustomerType {Id=2,TypeName="Affiliate", TypeCode="aff" },
                new CustomerType {Id=3,TypeName="Customer", TypeCode="cus" }
            };
            foreach (var i in customerTypes)
            {
                context.CustomerTypes.Add(i);
            }
            context.SaveChanges();
            ICollection<Order> orders = new List<Order>()
            {
               new Order { Id=1,OrderCode=00001, ProductCount=2,ProductsId=1, OrderTotalAmount=20m },
               new Order { Id=2,OrderCode=00001, ProductCount=1,ProductsId=2, OrderTotalAmount=12m },
               new Order { Id=3,OrderCode=00001, ProductCount=2,ProductsId=3, OrderTotalAmount=160m},
               new Order { Id=4,OrderCode=00002, ProductCount=1,ProductsId=4, OrderTotalAmount=1000m },
               new Order { Id=5,OrderCode=00003, ProductCount=2,ProductsId=5, OrderTotalAmount=40m },
               new Order { Id=6,OrderCode=00004, ProductCount=1,ProductsId=6, OrderTotalAmount=70m  },
               new Order { Id=7,OrderCode=00004, ProductCount=1,ProductsId=7, OrderTotalAmount=920m },
               new Order { Id=8,OrderCode=00005, ProductCount=3,ProductsId=8, OrderTotalAmount=15m },
               new Order { Id=9,OrderCode=00005, ProductCount=2,ProductsId=9, OrderTotalAmount=32m },
               new Order { Id=10,OrderCode=00005, ProductCount=1,ProductsId=2, OrderTotalAmount=24m },
            };

            foreach (var i in orders)
            {
                context.Orders.Add(i);
            }
            context.SaveChanges();
            ICollection<Customer> customer = new List<Customer>()
            {
                new Customer {Id=1,CustomerTypesId=1,Name="Emrah",Surname="Sinekli", Email="email@email.com", // Employee
                    Address="Sanliurfa", PhoneNumber="547147147",CreatedDate=DateTime.Now.AddYears(-3) }, 
                new Customer {Id=2,CustomerTypesId=2,Name="Ali",Surname="Kaya", Email="email@email.com", // Affiliate
                    Address="Istanbul", PhoneNumber="547147141",CreatedDate=DateTime.Now.AddYears(-1)}, 
                new Customer {Id=3,CustomerTypesId=3,Name="Ayşe",Surname="Toprak", Email="email@email.com", // Customer
                    Address="İzmir", PhoneNumber="547147142",CreatedDate=DateTime.Now.AddYears(-2)},
                new Customer {Id=4,CustomerTypesId=1,Name="Zeynep",Surname="Kahraman", Email="email@email.com", // Employee
                    Address="Bolu", PhoneNumber="547142147",CreatedDate=DateTime.Now.AddYears(-5)},
                new Customer {Id=5,CustomerTypesId=2,Name="Fatma",Surname="Güler", Email="email@email.com", // Affiliate
                    Address="Sanliurfa", PhoneNumber="547197147",CreatedDate=DateTime.Now},

            };

            foreach (var i in customer)
            {
                context.Customers.Add(i);
            }
            context.SaveChanges();
            ICollection<Invoice> invoices = new List<Invoice>()
            {
               new Invoice {Id=1,UserId=1,OrderCode=00001,InvoiceNumber="Invoice001", OrderTotal = 372m, Total=372m, CreatedDate=DateTime.Now.AddDays(-1)},
               new Invoice {Id=2,UserId=2,OrderCode=00002,InvoiceNumber="Invoice002", OrderTotal = 1000m, Total=1000m, CreatedDate=DateTime.Now.AddDays(-2)},
               new Invoice {Id=3,UserId=3,OrderCode=00003,InvoiceNumber="Invoice003", OrderTotal = 40m, Total=40m, CreatedDate=DateTime.Now.AddDays(-1)},
               new Invoice {Id=4,UserId=4,OrderCode=00004,InvoiceNumber="Invoice004", OrderTotal = 990m, Total=990m, CreatedDate=DateTime.Now.AddDays(-2)},
               new Invoice {Id=5,UserId=5,OrderCode=00005,InvoiceNumber="Invoice005", OrderTotal = 133m, Total=133m, CreatedDate=DateTime.Now.AddDays(-3)},
            };

            foreach (var i in invoices)
            {
                context.Invoices.Add(i);
            }
            context.SaveChanges();
        }
    }
}
