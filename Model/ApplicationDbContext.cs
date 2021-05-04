﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Model
{
    public class ApplicationDbContext : DbContext
    {
        // DbContext constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ExpenseHeader> ExpenseHeaders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

        }
    }
}