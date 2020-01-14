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
        private readonly PaymentRepository _payment;

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

        public void GetEditViewModel(int id , int quantity)
        {
            _paymentRepository.EditQuantity(id, quantity);
            
        }
        
        public EditViewModel GetPaymentById(int id)
        {
            var editpayPayment = _paymentRepository.GetPaymentById(id);

            return new EditViewModel() { Id = editpayPayment.Id, Quantity = editpayPayment.Quantity };
        }
    }
}