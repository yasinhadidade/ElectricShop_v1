using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class OrderDetail
    {
        [Key]
        public int DetailId { get; set; }
        public int Count { get; set; }
        public int ProductId { get; set; }
        public int OrderId { set; get; }
        public double Price { get; set; }
        public bool Isfinally { get; set; }
        public DateTime CreateDate { get; set; }

        //navigation property
        [ForeignKey("ProductId")]
        public Product product { get; set; }

        [ForeignKey("OrderId")]
        public Order order { get; set; }
    }
}
