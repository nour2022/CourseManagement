using FirstApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Data.Config
{
    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses");
            builder.HasKey(c => c.Id);
            builder.Property(c=>c.CourseName).HasColumnName("Course Name").HasColumnType("VARCHAR")
                .HasMaxLength(225).IsRequired();
            builder.Property(c => c.Price).HasPrecision(15, 2);
            builder.HasMany(c => c.Sections)
                .WithOne(c => c.Course)
                .IsRequired();
            builder.HasData(LoadCourseData());
        }
       
        private List<Course> LoadCourseData()
        {
            return new List<Course> {
            new Course
            {
                Id = 1,
                CourseName = "Mathematics",Price = 1000.00m,
            },
            new Course
            {
                Id = 2,
                CourseName = "Physics",
                Price = 2000.00m
            },
            new Course
            {
                Id = 3,
                CourseName = "Chemistry",
                Price = 1500.00m
            },new Course
            {
                Id = 4,
                CourseName = "Biology",
                Price = 1200.00m
            },new Course
            {
                Id = 5,
                CourseName = "Computer Science",
                Price = 3000.00m
            },
            };
        }
    }
}
