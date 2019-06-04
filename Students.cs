using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication7
{
   public class Students
    {
        public string Name { set; get; }
        public string LName { set; get; }
        public DateTime Birthday { set; get; }
        public int[] marks = new int[100];
        public string Number { get; set; }
        public Students()
        {
            Name = "Sofia";
            LName = "Rozhko";
            Birthday = new DateTime(2001,02,22);
        }

      public Students(string name, string lname, DateTime birth)
      {
            Name = name;
            LName = lname;
            Birthday = birth;
            Number = "";
      }

        public override string ToString()
        {
            return $"{Name} {LName} ";
        }
    }
}
