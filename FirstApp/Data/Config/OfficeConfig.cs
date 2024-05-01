using FirstApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Data.Config
{
    public class OfficeConfig : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.Property(o => o.Name).HasMaxLength(128).HasColumnType("VARCHAR");
            builder.HasKey(o => o.Id);
            builder.Property(o=>o.OfficeLocation).HasMaxLength(225).HasColumnType("VARCHAR");
            builder.HasData(LoadOfficeData());
        }

        private List<Office> LoadOfficeData()
        {
            return new List<Office>
            {

                    new Office { Id = 1, Name = "Off_05", OfficeLocation = "building A"},
                    new Office { Id = 2, Name = "Off_12", OfficeLocation = "building B"},
                    new Office { Id = 3, Name = "Off_32", OfficeLocation = "Adminstration"},
                    new Office { Id = 4, Name = "Off_44", OfficeLocation = "IT Department"},
                    new Office { Id = 5, Name = "Off_43", OfficeLocation = "IT Department"}
            };
        }
    }
}
