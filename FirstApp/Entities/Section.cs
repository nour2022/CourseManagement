using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Entities
{
    public class Section
    {
        public int Id { get; set; }
        public string SectionName { get; set; }
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
        public List<Schedule> Schedules { get; set; }
        public ICollection<SectionSchedule> SectionSchedules { get; set; } = new List<SectionSchedule>();

    }
}
