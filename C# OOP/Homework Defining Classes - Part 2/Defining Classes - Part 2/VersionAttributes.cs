using System;

namespace Defining_Classes___Part_2
{
    [AttributeUsage(AttributeTargets.Struct |
     AttributeTargets.Class | AttributeTargets.Interface | 
     AttributeTargets.Method | AttributeTargets.Enum)]

    public class VersionAttribute : System.Attribute
    {
        public int Major { get; set; }
        public int Minor { get;set; }

        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }
        public override string ToString()
        {
            return $"Version {this.Major}.{this.Minor}";
        }
    }

}
