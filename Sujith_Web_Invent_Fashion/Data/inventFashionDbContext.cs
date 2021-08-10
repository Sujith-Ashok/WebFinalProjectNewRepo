using System;
using Microsoft.EntityFrameworkCore;
using Sujith_Web_Invent_Fashion.Models;

namespace Sujith_Web_Invent_Fashion.Data
{
    public class inventFashionDbContext : DbContext
    {
        public inventFashionDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {


        }

        public DbSet<UserDetails> UserDetailss { get; set; }
        public DbSet<orderDetail> OrderDetails { get; set; }
    }
}
