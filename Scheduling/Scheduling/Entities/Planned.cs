using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling.Entities
{
    class Planned
    {
        public int Id { get; set; }
        public TimeSlot timeSlot { get; set; }
        public Subject subject { get; set; }
        public Room room { get; set; }
        public Group group { get; set; }
        public Teacher teacher { get; set; }

        public Planned(TimeSlot timeSlot, Subject subject, Room room, Group group, Teacher teacher)
        {
            this.timeSlot = timeSlot;
            this.subject = subject;
            this.room = room;
            this.group = group;
            this.teacher = teacher;
        }
    }
}
