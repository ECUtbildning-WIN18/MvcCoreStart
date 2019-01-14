using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreEcom.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderItemId { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public int UserId { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
