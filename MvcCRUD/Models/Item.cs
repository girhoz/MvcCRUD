using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcCRUD.Models
{
    [Table("TB_M_Item")]
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        //[RegularExpression("[a-zA-Z0-9]", ErrorMessage = "Please enter a valid item name!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Price is required.")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Stock is required.")]
        public int Stock { get; set; }
        [Required(ErrorMessage = "Supplier is required.")]
        public int SupplierId { get; set; }

        public virtual Supplier Supplier { get; set; } // Foreign Key
    }
}