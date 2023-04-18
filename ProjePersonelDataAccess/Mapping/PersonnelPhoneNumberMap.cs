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
    public class PersonnelPhoneNumberMap : IEntityTypeConfiguration<PersonelPhoneNumber>
    {
        public void Configure(EntityTypeBuilder<PersonelPhoneNumber> builder)
        {
            builder.HasKey(p => p.PersonnelPhoneNumberID);
            builder.Property(p => p.PersonnelPhoneNumberID).ValueGeneratedOnAdd();
            builder.Property(p => p.PhoneNumber).IsRequired();
            builder.Property(p => p.PhoneNumber).HasMaxLength(11);
            builder.Property(p => p.NumberDescription).IsRequired();
            builder.Property(p => p.NumberDescription).HasMaxLength(300);
            builder.Property(p => p.IsDeleted).IsRequired();
            builder.Property(p => p.IsActive).IsRequired();
            builder.ToTable("PersonnelPhoneNumbers");


            //foreing key  personels one to many

            builder.HasOne<Personnel>(a => a.Personnel).WithMany(p => p.PersonnelPhoneNumbers).HasForeignKey(p => p.PersonnelID);

            builder.HasData(new PersonelPhoneNumber
            {
                PersonnelPhoneNumberID = 1,
                PhoneNumber = "98763215472",
                NumberDescription = "Cep Telefon Numarası",
                PersonnelID = 1,
                IsActive = true,
                IsDeleted = false,
                CreatedDateTime = DateTime.Now,



            });

        }
    }
}
