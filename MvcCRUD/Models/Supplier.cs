using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcCRUD.Models
{
    [Table("TB_M_Supplier")]//Definisi Nama Tabel
    public class Supplier
    {
        [Key] //Definisi primary key (yang dibawah key menjadi primary key)
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Email is required!")]
        [RegularExpression("[a-zA-Z0-9._]+@gmail+.com", ErrorMessage = "Please enter a valid email address!")]
        public string Email { get; set; }

        public Supplier()
        {

        }
    }
}