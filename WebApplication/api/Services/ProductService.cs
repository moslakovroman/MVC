using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using api.Interfaces;
using api.Repositories;
using model;
using model.ViewModels;


namespace api.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepoProduct _productRepository;
        private readonly IRepoUser _userRepository;
        private readonly IRepoPayment _paymentRepository;


        public ProductService(IRepoProduct productRepository, IRepoUser userRepository, IRepoPayment paymentRepository)
        {
            _productRepository = productRepository;
            _userRepository = userRepository;
            _paymentRepository = paymentRepository;
        }

        
        public List<User> GetUsers()
        {
            return _userRepository.GetUsers();
        }
        public List<Product> GetProducts()
        {
            
            return _productRepository.GetIndexData();
        }

        public List<Payment> GetPurchase()
        {
            return _paymentRepository.GetPurchase();
        }

        public ProductUserViewModel GetProductUserViewModel()
        {
            return new ProductUserViewModel(){Products = GetProducts(), Users = GetUsers()};
        }

        public ProductUsersPaymentViewModel GetProductUserPaymentViewModel()
        {
            return new ProductUsersPaymentViewModel()
            { Products = GetProducts(), Users = GetUsers(), Payments = GetPurchase() };
        }

        public List<ProductUsersPaymentViewModel2> GetProductUserPaymentViewModel2()
        {
            return _paymentRepository.GetPupViewModel();

        }

        public void GetEditViewModel(EditViewModel getEditViewModel)
        {
            _paymentRepository.EditQuantity(getEditViewModel);
            
        }
        
        public Payment GetPaymentById(int id)
        {
            var editpayPayment = _paymentRepository.GetPaymentById(id);
            

            return new Payment()
            {
                Id = editpayPayment.Id, Quantity = editpayPayment.Quantity,
                
            };
        }

        public EditViewModel GetPaymentByAllId(int id)
        {
            var editpayPayment = _paymentRepository.GetPaymentById(id);
            var editProduct = _paymentRepository.GetProductByPaymentId(id);
            var editUser = _paymentRepository.GetUserByPaymentId(id);

            return new EditViewModel()
            {
                PaymentId = editpayPayment.Id,
                Quantity = editpayPayment.Quantity,
                Description = editProduct.Description,
                Name = editProduct.Name,
                Price = editProduct.Price,
                Login = editUser.Login,
                Age = editUser.Age,
                ProductId = editUser.Id,
                UserId = editUser.Id
            };
        }

        //public EditViewModel GetProductByPaymentId(int PaymentId)
        //{
        //    var editProduct = _paymentRepository.GetProductById(id);

        //    return new EditViewModel()
        //    {
        //        Description = editProduct.Description,
        //        Name = editProduct.Name,
        //        Price = editProduct.Price
        //    };
        //}
        //public EditViewModel GetUserById(int id)
        //{
        //    var editUser = _paymentRepository.GetUserById(id);

        //    return new EditViewModel()
        //    {
        //        Login = editUser.Login,
        //        Age = editUser.Age
        //    };
        //}
    }
}