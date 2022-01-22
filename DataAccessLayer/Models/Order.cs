using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsFinally { get; set; }
        public int UserId { get; set; }
        public double Sum { get; set; }

        //navigation property
        [ForeignKey("UserId")]
        public User user { get; set; }
        public List<OrderDetail> orderDetails { get; set; }

    }
}
