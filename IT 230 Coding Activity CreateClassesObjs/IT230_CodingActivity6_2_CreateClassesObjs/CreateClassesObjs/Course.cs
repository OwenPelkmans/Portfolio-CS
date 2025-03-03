using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClassesObjs
{
    public class Course
    {
        private string name;  

        public void SetName(string name)
        {
                this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}

