using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication7
{
   public class Teachers
    {
        public string TName { set; get; }
        public string TLName { set; get; }
        public string Number { get; set; }
        
       public List<Students> student = new List<Students>();

        public override string ToString()
        {
            return TName + " " + TLName; 
        }

        public Teachers(string name,string lname,string number)
        {
            TName = name;
            TLName = lname;
            Number = number;
        }
    }
}
