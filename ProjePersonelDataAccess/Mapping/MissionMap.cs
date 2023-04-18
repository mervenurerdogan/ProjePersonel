using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjePersonelCore.Entities;
using ProjePersonelModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelDataAccess.Mapping
{
    public class MissionMap : IEntityTypeConfiguration<Mission>
    {
        public void Configure(EntityTypeBuilder<Mission> builder)
        {
            builder.HasKey(p => p.MissionID);
            builder.Property(p => p.MissionID).ValueGeneratedOnAdd();
            builder.Property(p => p.MissionName).IsRequired();
            builder.Property(p => p.MissionName).HasMaxLength(150);
            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(300);
            builder.Property(p => p.IsDeleted).IsRequired();
            builder.Property(p => p.IsActive).IsRequired();
            builder.ToTable("PersonnelMissions");

            //foreing key gelecek depatman one to many

            builder.HasOne<Departman>(d => d.Departman).WithMany(p => p.Missions).HasForeignKey(p => p.DepartmanID);
            builder.HasData(new Mission
            {
                MissionID = 1,
                MissionName = "Mühendis",
                Description = "A şirketi  yazılım bölümünde çalışan görevi mühendis olan kişi",
                DepartmanID = 1,
                IsActive = true,
                IsDeleted = false,
                CreatedDateTime = DateTime.Now,


            },
            new Mission
            {
                MissionID = 2,
                MissionName = "Muhasebeci",
                Description = "A şirketi  muhasebe bölümünde çalışan görevi muhasebeci olan kişi",
                DepartmanID = 2,
                IsActive = true,
                IsDeleted = false,
                CreatedDateTime = DateTime.Now,


            }
            );
        }
    }
}
