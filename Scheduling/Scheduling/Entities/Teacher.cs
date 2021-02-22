using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling
{
    class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Teacher(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
