﻿using AcunmedyaAkademiBabyCare.Entities;
using Microsoft.EntityFrameworkCore;

namespace AcunmedyaAkademiBabyCare.Context
{
    public class BabyCareContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SEYDANUR;initial catalog=AcunmedyaDbBabyCare;integrated security=true;");
        }
        public DbSet<Feature> Features { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutList> AboutLists { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Testimonial> Testimonials { get; set;}
        public DbSet<Event> Events { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
