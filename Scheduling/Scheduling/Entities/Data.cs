using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling.Entities
{
    class Data
    {
        public List<Group> Groups { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<TimeSlot> TimeSlots { get; set; }

        public Data()
        {
            Groups = new List<Group>();
            Rooms = new List<Room>();
            Subjects = new List<Subject>();
            Teachers = new List<Teacher>();
            TimeSlots = new List<TimeSlot>();

            Groups.Add(new Group(1, "Group1", 15));
            Groups.Add(new Group(2, "Group2", 30));
            Groups.Add(new Group(3, "Group3", 30));

            Subjects.Add(new Subject(1, "Subject1", 1, false));
            Subjects.Add(new Subject(2, "Subject2", 2, true));
            Subjects.Add(new Subject(3, "Subject3", 2, false));
            Subjects.Add(new Subject(4, "Subject4", 2, true));
            Subjects.Add(new Subject(5, "Subject5", 3, false));
            Subjects.Add(new Subject(6, "Subject6", 2, true));

            Rooms.Add(new Room(1, "228", 15));
            Rooms.Add(new Room(2, "322", 15));
            Rooms.Add(new Room(3, "69", 30));
            Rooms.Add(new Room(4, "96", 30));

            Teachers.Add(new Teacher(1, "Teacher1"));
            Teachers.Add(new Teacher(2, "Teacher2"));
            Teachers.Add(new Teacher(3, "Teacher3"));
            Teachers.Add(new Teacher(4, "Teacher4"));

            TimeSlots.Add(new TimeSlot(1, "Mon", "8:40-10:15"));
            TimeSlots.Add(new TimeSlot(2, "Mon", "10:35-12:10"));
            TimeSlots.Add(new TimeSlot(3, "Mon", "12:20-13:55"));
            TimeSlots.Add(new TimeSlot(4, "Mon", "14:05-15:45"));
            TimeSlots.Add(new TimeSlot(5, "Tue", "8:40-10:15"));
            TimeSlots.Add(new TimeSlot(6, "Tue", "10:35-12:10"));
            TimeSlots.Add(new TimeSlot(7, "Tue", "12:20-13:55"));
            TimeSlots.Add(new TimeSlot(8, "Tue", "14:05-15:45"));
            TimeSlots.Add(new TimeSlot(9, "Wed", "8:40-10:15"));
            TimeSlots.Add(new TimeSlot(10, "Wed", "10:35-12:10"));
            TimeSlots.Add(new TimeSlot(11, "Wed", "12:20-13:55"));
            TimeSlots.Add(new TimeSlot(12, "Wed", "14:05-15:45"));
            TimeSlots.Add(new TimeSlot(13, "Thu", "8:40-10:15"));
            TimeSlots.Add(new TimeSlot(14, "Thu", "10:35-12:10"));
            TimeSlots.Add(new TimeSlot(15, "Thu", "12:20-13:55"));
            TimeSlots.Add(new TimeSlot(16, "Thu", "14:05-15:45"));
            TimeSlots.Add(new TimeSlot(17, "Fr", "8:40-10:15"));
            TimeSlots.Add(new TimeSlot(18, "Fr", "10:35-12:10"));
            TimeSlots.Add(new TimeSlot(19, "Fr", "12:20-13:55"));
            TimeSlots.Add(new TimeSlot(20, "Fr", "14:05-15:45"));
        }

    }
}
