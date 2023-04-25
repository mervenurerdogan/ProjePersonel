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
    public class PlaceOfBirthMap : IEntityTypeConfiguration<PlaceOfBirth>
    {
        public void Configure(EntityTypeBuilder<PlaceOfBirth> builder)
        {
            builder.HasKey(p => p.CityID);
            builder.Property(p => p.CityID).ValueGeneratedOnAdd();
            builder.Property(p=>p.CityName).IsRequired();
            builder.ToTable("PlaceOfBirths");

            builder.HasData(new PlaceOfBirth
            {
                CityID = 1,
                CityName ="Adana",
                IsDeleted = false,
                IsActive = true,
                CreatedDateTime = DateTime.Now
            }

          );
        }
    }
}
