﻿using Microsoft.EntityFrameworkCore;

namespace Demo_Project_GraphQL.Model.Entities
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        { 
        
        }
        public DbSet<Cake> Cake { get; set; }

    }
}
