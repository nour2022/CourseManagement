using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Entities
{
    public class Office
    {
        public int Id { get; set; }
        public Instructor Instructor { get; set; }

        public string Name { get; set; }
        public string OfficeLocation { get; set; }
    }
}
