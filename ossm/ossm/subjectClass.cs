using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ossm
{
    
    public class SubjectClass
    {
        private string time;
        private string day;
        private string code;
        public SubjectClass(string time, string day, string code)
        {
            this.time = time;
            this.day = day;
            this.code = code;
        }
        public string getTime()
        {
            return time;
        }
        public string getDay()
        {
            return day;
        }
        public string getCode()
        {
            return code;
        }
    }
}
