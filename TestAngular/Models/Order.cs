using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestAngular.Models
{
    public class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
    public class Order:BaseEntity
    {
        public Order()
        {
            CreateDate = DateTime.Now;
        }

        //[Key]
        //[DatabaseGenerated( DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        public DateTime CreateDate { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
    public class OrderDetail:BaseEntity
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }
        [Required]
        public string GoodCode { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int OrderId { get; set; }

        public Order Order { get; set; }
    }

    public class Customer:BaseEntity
    {
        [Required]
        public string FullName { get; set; }
        public string Phone { get; set; }
    }
}