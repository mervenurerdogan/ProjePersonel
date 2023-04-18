using Microsoft.EntityFrameworkCore;
using ProjePersonelModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-QUGP58L\SQLEXPRESS;Database=ProjePersonnel;Trusted_Connection=True;TrustServerCertificate=True");

        }
    }

  
}
