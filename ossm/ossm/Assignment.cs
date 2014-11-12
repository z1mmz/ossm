using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ossm
{
    class Assignment
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
        public Boolean save()
        {
    
            // do object saving here
            return true;
        }


    }
}
