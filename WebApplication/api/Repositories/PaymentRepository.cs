using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using api.Interfaces;
using model;
using model.ViewModels;

namespace api.Repositories
{
    public class PaymentRepository: IRepoPayment

    {
        //public List<Payment> payments;

        public List<Payment> GetPurchase()
        {
            //payments = new List<Payment>();

            //payments.Add(new Payment()
            //{
            //    ProductId = 1,
            //    Id = 3,
            //    UserId = 3,
            //    Quantity = 3
            //});

            //payments.Add(new Payment()
            //{
            //    ProductId = 2,
            //    Id = 1,
            //    UserId = 2,
            //    Quantity = 5
            //});

            //payments.Add(new Payment()
            //{
            //    ProductId = 3,
            //    Id = 2,
            //    UserId = 1,
            //    Quantity = 8
            //});
            return null;/*payments*/;
        }

        private static List<Payment> _payments = InitPayment();

        private static List<Payment> InitPayment()
        {
            return new List<Payment>()
            {
                new Payment() {ProductId = 1, Id = 3, UserId = 3, Quantity = 3},
                new Payment() {ProductId = 2, Id = 1, UserId = 2, Quantity = 5},
                new Payment() {ProductId = 3, Id = 2, UserId = 1, Quantity = 8}
            };
            

            //payments.Add(new Payment()
            //{
            //    ProductId = 1,
            //    Id = 3,
            //    UserId = 3,
            //    Quantity = 3
            //});

            //payments.Add(new Payment()
            //{
            //    ProductId = 2,
            //    Id = 1,
            //    UserId = 2,
            //    Quantity = 5
            //});

            //payments.Add(new Payment()
            //{
            //    ProductId = 3,
            //    Id = 2,
            //    UserId = 1,
            //    Quantity = 8
            //});
        }

        private static List<User> _users = InitUsers();

        private static List<User> InitUsers()
        {
            return _users = new List<User>()
            {
                new User() {Login = "lopata", Age = 30, Id = 1},
                new User() {Login = "chehol", Age = 20, Id = 2},
                new User() {Login = "holop", Age = 25, Id = 3}
            };
            

            //users.Add(new User()
            //{
            //    Login = "lopata",
            //    Age = 30,
            //    Id = 1
            //});
            //users.Add(new User()
            //{
            //    Login = "chehol",
            //    Age = 20,
            //    Id = 2
            //});
            //users.Add(new User()
            //{
            //    Login = "holop",
            //    Age = 25,
            //    Id = 3
            //});
           
        }

        private static List<Product> _products = InitProducts();

        private static List<Product> InitProducts()
        {
            return _products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Phone", Price = 300, Description = "Samsung" },
                new Product() { Id = 2, Name = "Notebook", Price = 2300, Description = "MSI" },
                new Product() { Id = 3, Name = "Monitor", Price = 500, Description = "Dell" }
            };
            

            //products.Add(new Product()
            //{
            //    Id = 1,
            //    Name = "Phone",
            //    Price = 300,
            //    Description = "Samsung"
            //});
            //products.Add(new Product()
            //{
            //    Id = 2,
            //    Name = "Notebook",
            //    Price = 2300,
            //    Description = "MSI"
            //});
            //products.Add(new Product()
            //{
            //    Id = 3,
            //    Name = "Monitor",
            //    Price = 500,
            //    Description = "Dell"
            //});
            
        }

        

        //public PaymentRepository()
        //{
        //    products = new List<Product>();

        //    products.Add(new Product()
        //    {
        //        Id = 1,
        //        Name = "Phone",
        //        Price = 300,
        //        Description = "Samsung"
        //    });
        //    products.Add(new Product()
        //    {
        //        Id = 2,
        //        Name = "Notebook",
        //        Price = 2300,
        //        Description = "MSI"
        //    });
        //    products.Add(new Product()
        //    {
        //        Id = 3,
        //        Name = "Monitor",
        //        Price = 500,
        //        Description = "Dell"
        //    });

        //    users = new List<User>();

        //    users.Add(new User()
        //    {
        //        Login = "lopata",
        //        Age = 30,
        //        Id = 1
        //    });
        //    users.Add(new User()
        //    {
        //        Login = "chehol",
        //        Age = 20,
        //        Id = 2
        //    });
        //    users.Add(new User()
        //    {
        //        Login = "holop",
        //        Age = 25,
        //        Id = 3
        //    });
        //    payments = new List<Payment>();

        //    payments.Add(new Payment()
        //    {
        //        ProductId = 1,
        //        Id = 3,
        //        UserId = 3,
        //        Quantity = 3
        //    });

        //    payments.Add(new Payment()
        //    {
        //        ProductId = 2,
        //        Id = 1,
        //        UserId = 2,
        //        Quantity = 5
        //    });

        //    payments.Add(new Payment()
        //    {
        //        ProductId = 3,
        //        Id = 2,
        //        UserId = 1,
        //        Quantity = 8
        //    });
        //}

        

        private List<ProductUsersPaymentViewModel2> ItogViewModel;
        public List<ProductUsersPaymentViewModel2> GetPupViewModel()
        { 
            
            var resault = from pay in _payments
                join use in _users on pay.UserId equals use.Id
                join pro in _products on pay.ProductId equals pro.Id
                select new ProductUsersPaymentViewModel2
                {
                    Name = pro.Name,
                    Description = pro.Description,
                    Price = pro.Price,
                    Login = use.Login,
                    Age = use.Age,
                    Quantity = pay.Quantity,
                    Sum = pro.Price * pay.Quantity

                };
          

            return resault.ToList();
        }
    }
}