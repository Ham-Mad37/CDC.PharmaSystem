using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CDC.PharmaSystem.Wep.Data
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        [ValidateNever]
        public ApplicationUser User { get; set; }
        public int UserId { get; set; }

    }
}
