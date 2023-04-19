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
    public class GenderMap : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasKey(g => g.GenderID);
            builder.Property(g=>g.GenderID).ValueGeneratedOnAdd();
            builder.Property(g => g.GenderName);
            builder.ToTable("Genders");
            builder.Property(d => d.IsDeleted).IsRequired();
            builder.Property(d => d.IsActive).IsRequired();
            builder.ToTable("Genders");

            builder.HasData(new Gender
            {
                GenderID = 1,
                GenderName = "Kadın",
                IsDeleted = false,
                IsActive = true,
                CreatedDateTime = DateTime.Now
            },new Gender
            {
                GenderID = 2,
                GenderName = "Erkek",
                IsDeleted = false,
                IsActive = true,
                CreatedDateTime = DateTime.Now
            }
            
            );

        
        }
    }
}
