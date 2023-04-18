using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjePersonelModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelDataAccess.Mapping
{
    public class DepartmanMap : IEntityTypeConfiguration<Departman>
    {
        public void Configure(EntityTypeBuilder<Departman> builder)
        {
            builder.HasKey(d => d.DepartmanID);
            builder.Property(d => d.DepartmanID).ValueGeneratedOnAdd();
            builder.Property(d => d.DepartmanName).IsRequired();
            builder.Property(d => d.DepartmanName).HasMaxLength(100);
            builder.Property(d => d.Description).HasMaxLength(300);
            builder.Property(d => d.Description).HasMaxLength(300);
            builder.Property(d => d.IsDeleted).IsRequired();
            builder.Property(d => d.IsActive).IsRequired();
            builder.ToTable("Departments");
          

            builder.HasData(new Departman
            {
                DepartmanID = 1,
                DepartmanName = "Yazılım",
                Description = "A şirketinin    Yazılım Bölümü ",
               
                IsActive = true,
                IsDeleted = false,
                CreatedDateTime = DateTime.Now,



            }, new Departman
            {
                DepartmanID = 2,
                DepartmanName = "Muhasebe",
                Description = "A şirketinin    Muhasebe Bölümü ",

                IsActive = true,
                IsDeleted = false,
                CreatedDateTime = DateTime.Now,



            }

            );
        }
    }
}
