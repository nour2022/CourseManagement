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
    public class InstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(i => i.Id);
            builder.ToTable("Instructors");
           
            builder.Property(i => i.Name).HasColumnType("VARCHAR").HasMaxLength(225);
            builder.HasOne(x=>x.Office).WithOne(x=>x.Instructor).HasForeignKey<Instructor>(i=>i.officeId).IsRequired();
            builder.HasData(LoadInstructorData());
        }
       
        private List<Instructor> LoadInstructorData()
        {
            return new List<Instructor> { 
                new Instructor(){
                    Id = 1,
                    Name = "Ahmed Abdullah",
                    officeId = 1,
            },
              new Instructor(){
                    Id = 2,
                    Name = "Yasmeen Mohammed",
                    officeId = 2,
            },
              new Instructor(){
                    Id = 3,
                    Name = "Khalid Hassan",
                    officeId = 3,
            },
              new Instructor(){
                    Id = 4,
                    Name = "Nadia Ali",
                    officeId = 4,
            },  new Instructor(){
                    Id = 5,
                    Name = "Omar Ibrahim",
                    officeId = 5,
            }};
        }
    }
}
