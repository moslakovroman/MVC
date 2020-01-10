using System.Collections.Generic;
using model;
using model.ViewModels;

namespace api.Interfaces
{
    public interface IRepoPayment
    {
        List<Payment> GetPurchase();

        List<ProductUsersPaymentViewModel2> GetPupViewModel();
    }
}