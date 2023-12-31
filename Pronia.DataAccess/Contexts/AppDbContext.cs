﻿using Microsoft.EntityFrameworkCore;
using Pronia.Core.Entities;

namespace Pronia.DataAccess.Contexts;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
    public DbSet<Slider> Sliders { get; set; } = null!;
    public DbSet<Shipping> Shippings { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Banner> Banners { get; set; } = null!;
    public DbSet<NewProduct> NewProducts { get; set; } = null!;
}
