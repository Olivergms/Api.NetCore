using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiProducts.Models;

namespace ApiProducts.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options)
      : base(options)
    {
    }


    public DbSet<Product> Products { get; set; }

    public DbSet<Category> Categories { get; set; }

  }
}
