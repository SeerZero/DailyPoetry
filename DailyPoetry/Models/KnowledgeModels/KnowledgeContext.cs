﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DailyPoetry.Models.KnowledgeModels
{

    public class KnowledgeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlite("Data Source=db.sqlite3");
        }

        public DbSet<PoetryItem> PoetryItems { get; set; }
        public DbSet<CategoryItem> CategoryItems { get; set; }
        public DbSet<CategoryWorkItem> CategoryWorkItems { get; set; }
        public DbSet<WriterItem> WriterItems { get; set; }

        [DbFunction("instr")]
        public static int SatisfiesMyUserFunction(string x, string y)
        {
            throw new Exception(); // this code doesn't get executed; the call is passed through to the database function
        }
    }
}
