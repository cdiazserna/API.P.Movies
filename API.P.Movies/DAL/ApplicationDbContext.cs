﻿using API.P.Movies.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace API.P.Movies.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //Todos los DBSets - las nuevas tablas

        public DbSet<Category> Categories { get; set; }
    }
}
