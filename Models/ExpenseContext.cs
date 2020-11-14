﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Preotu_Andrei_Lab5.Models;

namespace Preotu_Andrei_Lab5.Models
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options)
        : base(options)
        {
        }
        public DbSet<ExpenseDTO> ExpenseDTO { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public object Expense { get; internal set; }
        public DbSet<Budget> Budget { get; set; }
    }
}
