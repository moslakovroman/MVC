using System.Collections.Generic;

namespace model.ViewModels
{
    public class EditViewModel
    {
        //public int Id { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public int Price { get; set; }
        public string Login { get; set; }
        public double Sum { get; set; }
        public int PaymentId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
    }
}