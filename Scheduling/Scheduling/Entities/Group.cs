using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling.Entities
{
    class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }

        public Group(int Id, string Name, int Size)
        {
            this.Id = Id;
            this.Name = Name;
            this.Size = Size;
        }
    }
}
