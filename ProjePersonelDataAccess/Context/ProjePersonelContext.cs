﻿using Microsoft.EntityFrameworkCore;
using ProjePersonelDataAccess.Mapping;
using ProjePersonelModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelDataAccess.Context
{
    public class ProjePersonelContext:DbContext
    {
        public DbSet<Departman> Departmen { get; set; }
        public DbSet<Personnel> Personnel { get; set; }
        public DbSet<PersonelPhoneNumber> PersonelPhoneNumbers { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<PersonnelAddress> Addresses { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<PlaceOfBirth> PlaceOfBirths { get; set; }
        public DbSet<EducationStatus> EducationStatuses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-QUGP58L\SQLEXPRESS;Database=ProjePersonnelDB;Trusted_Connection=True;TrustServerCertificate=True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.ApplyConfiguration(new DepartmanMap());
            modelBuilder.ApplyConfiguration(new PersonnelPhoneNumberMap());
            modelBuilder.ApplyConfiguration(new PersonelAddressMap());
            modelBuilder.ApplyConfiguration(new PersonnelMap());
            modelBuilder.ApplyConfiguration(new MissionMap());
            modelBuilder.ApplyConfiguration(new GenderMap());
            modelBuilder.ApplyConfiguration(new PlaceOfBirthMap());
            modelBuilder.ApplyConfiguration(new EducationStatusMap());
        }
    }

  
}
