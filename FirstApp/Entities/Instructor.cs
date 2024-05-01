using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Entities
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int officeId { get; set; }
        public Office Office { get; set; }
        public ICollection<Section> Sections { get; set; } = new List<Section>();
    }
}
