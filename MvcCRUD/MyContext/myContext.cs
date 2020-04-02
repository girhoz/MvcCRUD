using MvcCRUD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcCRUD.MyContext
{
    public class myContext : DbContext
    {
        public myContext(): base("MvcCRUD") { }
        public DbSet<Supplier> Suppliers { get; set; } //Mendaftarkan tabel yang sudah dibuat
        public DbSet<Item> Items { get; set; }
    }
}