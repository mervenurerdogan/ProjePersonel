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
    public class PersonnelMap : IEntityTypeConfiguration<Personnel>
    {
        public void Configure(EntityTypeBuilder<Personnel> builder)
        {

            builder.HasKey(p => p.PersonnelID);
            builder.Property(p => p.PersonnelID).ValueGeneratedOnAdd();
            builder.Property(p => p.IdentityNumber).IsRequired();
            builder.Property(p => p.IdentityNumber).HasMaxLength(11);
            builder.HasIndex(p => p.IdentityNumber).IsUnique();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(50);
            builder.Property(p => p.Surname).IsRequired();
            builder.Property(p => p.Surname).HasMaxLength(50);
            builder.Property(p => p.BirthDate).IsRequired();
            builder.Property(p => p.StartWorkDate).IsRequired();
            builder.Property(p => p.Email).IsRequired();
            builder.Property(p => p.SummaryInfoPersonnel).HasMaxLength(300);
            builder.Property(p => p.IsDeleted).IsRequired();
            builder.Property(p => p.IsActive).IsRequired();
            //builder.Property(p => p.Aktifmi).HasComputedColumnSql("(CASE WHEN FinishWorkDate  IS NULL THEN 1 ELSE 0 END)");
            builder.Property(p => p.Aktifmi).HasComputedColumnSql("(CASE WHEN FinishWorkDate IS NULL THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END)");

            builder.ToTable("Personnels");

            //foreign key one to many branch,departman,mission

            builder.HasOne<Departman>(d => d.Departman).WithMany(p => p.Personnels).HasForeignKey(p => p.DepartmanID);
            builder.HasOne<Mission>(m => m.Mission).WithMany(p => p.Personnels).HasForeignKey(p => p.MissionID);
            builder.HasOne<Gender>(g => g.Gender).WithMany(p => p.Personnels).HasForeignKey(p => p.GenderID);
            builder.HasOne<PlaceOfBirth>(g => g.PlaceOfBirth).WithMany(p => p.Personnels).HasForeignKey(p => p.PlaceOfBirthID);
            builder.HasOne<EducationStatus>(g => g.EducationStatus).WithMany(p => p.Personnels).HasForeignKey(p => p.EducationID);

            builder.HasData(new Personnel
            {
                PersonnelID = 1,
                IdentityNumber = "98765432122",
                Name = "Ayşe",
                Surname = "Yılmaz",
                BirthDate = new DateTime(1985, 3, 15),
                EducationID = 1,
                FinishWorkDate = new DateTime(2022, 2, 1, 8, 0, 0),
                StartWorkDate = new DateTime(2022, 2, 1, 17, 0, 0),
                Email = "user@gmail.com",
                GenderID=1,
                SummaryInfoPersonnel = "Personel Açıklama hakkında ",
                DepartmanID = 1,
                MissionID = 1,
                PlaceOfBirthID =1,
                IsActive = true,
                IsDeleted = false,
                CreatedDateTime = DateTime.Now,
                UpdateDateTime=DateTime.Now
            }, new Personnel
            {
                PersonnelID = 2,
                IdentityNumber = "58715432129",
                Name = "Ali",
                Surname = "Er",
                BirthDate = new DateTime(1991, 3, 20),
                EducationID = 1,
                StartWorkDate = new DateTime(2020, 2, 1, 17, 0, 0),
                Email = "user@gmail.com",
                GenderID = 1,
                SummaryInfoPersonnel = "Personel Açıklama hakkında ",
                DepartmanID = 1,
                MissionID = 1,
                PlaceOfBirthID = 1,
                IsActive = true,
                IsDeleted = false,
                CreatedDateTime = DateTime.Now,
                UpdateDateTime = DateTime.Now
            }
            );

        }
     }
    }
