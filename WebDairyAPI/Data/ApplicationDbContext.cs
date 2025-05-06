﻿using Microsoft.EntityFrameworkCore;
using WebDairyAPI.Model;

namespace WebDairyAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }
    }
}
