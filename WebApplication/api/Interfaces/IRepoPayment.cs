using System.Collections.Generic;
using model;
using model.ViewModels;

namespace api.Interfaces
{
    public interface IRepoPayment
    {
        List<Payment> GetPurchase();

        List<ProductUsersPaymentViewModel2> GetPupViewModel();

        void EditQuantity(int id, int quantity);
        Payment GetPaymentById(int id);
    }
}