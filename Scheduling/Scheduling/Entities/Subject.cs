using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling.Entities
{
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
}
