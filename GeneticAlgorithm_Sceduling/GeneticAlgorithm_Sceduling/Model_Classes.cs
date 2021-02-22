using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
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
    class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TimesPerWeek { get; set; }
        public bool IsLab { get; set; }

        public Subject(int Id, string Name, int TimesPerWeek, bool IsLab)
        {
            this.Id = Id;
            this.Name = Name;
            this.TimesPerWeek = TimesPerWeek;
            this.IsLab = IsLab;
        }
    }
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
    class TimeSlot
    {
        public int Id { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }

        public TimeSlot(int Id, string Day, string Time)
        {
            this.Id = Id;
            this.Day = Day;
            this.Time = Time;
        }
    }
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
