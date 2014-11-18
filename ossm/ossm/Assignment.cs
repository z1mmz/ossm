using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ossm
{
    public class Assignment
    {
        private String name;
        private DateTime dueDate;
        private String description;
        public Assignment(String name, DateTime dueDate, String description)
        {
            this.name = name;
            this.dueDate = dueDate;
            this.description = description;
        }
        public string getAssignmentString()
        {
            string returnString = name + " Due Date " + dueDate + " Decription " + description;
            return returnString;
        }
        //No longer needed as appDriver saves all classes in array
        //public Boolean save()
        //{
    
        //    // do object saving here
        //    return true;
        //}


    }
}
