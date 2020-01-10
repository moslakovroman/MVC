using api.Interfaces;
using api.Repositories;
using api.Services;
using Ninject.Modules;

namespace api.IOC
{
    public class IocModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductService>();
            Bind<IRepoProduct>().To<ProductRepository>();
            Bind<IRepoUser>().To<UserRepository>();
            Bind<IRepoPayment>().To<PaymentRepository>();
        }
    }
}