using System;
using System.Collections.Generic;
using System.Text;
using api.Repositories;
using model;
using model.ViewModels;


namespace api.Interfaces

{
    public interface IProductService
    {
        List<Product> GetProducts();

        List<User> GetUsers();

        List<Payment> GetPurchase();

        ProductUserViewModel GetProductUserViewModel();
        ProductUsersPaymentViewModel GetProductUserPaymentViewModel();

        List<ProductUsersPaymentViewModel2> GetProductUserPaymentViewModel2();

        void GetEditViewModel(EditViewModel editViewModel);
        Payment GetPaymentById(int id);
        EditViewModel GetPaymentByAllId(int id);
    }
}