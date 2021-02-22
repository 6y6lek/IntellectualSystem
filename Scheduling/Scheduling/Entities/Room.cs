using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling.Entities
{
    class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public Room(int Id, string Name, int Capacity)
        {
            this.Id = Id;
            this.Name = Name;
            this.Capacity = Capacity;
        }
    }
}
