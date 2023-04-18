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
    public class PersonelAddressMap : IEntityTypeConfiguration<PersonnelAddress>
    {
        public void Configure(EntityTypeBuilder<PersonnelAddress> builder)
        {
            builder.HasKey(p => p.AdressID);
            builder.Property(p => p.AdressID).ValueGeneratedOnAdd();
            builder.Property(p => p.Address).IsRequired();
            builder.Property(p => p.Address).HasMaxLength(300);
            builder.Property(p => p.AddressDescription).IsRequired();
            builder.Property(p => p.AddressDescription).HasMaxLength(300);
            builder.Property(p => p.IsDeleted).IsRequired();
            builder.Property(p => p.IsActive).IsRequired();

            builder.ToTable("PersonnelAddresses");

            //foreing key  personels one to many

            builder.HasOne<Personnel>(a => a.Personnel).WithMany(p => p.PersonnelAddresses).HasForeignKey(p => p.PersonnelID);

            builder.HasData(new PersonnelAddress
            {
                AdressID = 1,
                Address = "Çiçek sokak gül apartmanı No10",
                AddressDescription = "Ev Adresi",
                PersonnelID = 1,
                IsActive = true,
                IsDeleted = false,
                CreatedDateTime = DateTime.Now,



            });

        }
    }
}
