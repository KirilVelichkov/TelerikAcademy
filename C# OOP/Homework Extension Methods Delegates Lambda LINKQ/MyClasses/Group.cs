using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
   public class Group
    {

        public uint GroupNumber { get; set; }
        public string DepartmentName { get; set; }

        public Group(uint groupNumber, string departmentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }
    }
}
