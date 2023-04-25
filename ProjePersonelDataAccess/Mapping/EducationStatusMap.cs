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
    public class EducationStatusMap : IEntityTypeConfiguration<EducationStatus>
    {
        public void Configure(EntityTypeBuilder<EducationStatus> builder)
        {
            builder.HasKey(e => e.EducationID);
            builder.Property(e=>e.EducationID).ValueGeneratedOnAdd();
            builder.Property(e=>e.EducationStatusName).IsRequired();
            builder.ToTable("EducationStatuses");

            builder.HasData(new EducationStatus
            {

                EducationID = 1,
                EducationStatusName="İlköğretim",
                IsActive=true,
                IsDeleted=false,
                CreatedDateTime=DateTime.Now
            });
           
        }
    }
}
