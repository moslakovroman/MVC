using System.Collections.Generic;
using model;
using model.ViewModels;

namespace api.Interfaces
{
    public interface IRepoPayment
    {
        List<Payment> GetPurchase();

        List<ProductUsersPaymentViewModel2> GetPupViewModel();

        void EditQuantity(EditViewModel editViewModel);
        Payment GetPaymentById(int id);
        Product GetProductByPaymentId(int id);
        User GetUserByPaymentId(int id);
        
    }
}