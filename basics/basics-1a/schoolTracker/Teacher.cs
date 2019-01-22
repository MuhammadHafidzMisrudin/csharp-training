using System;
using System.Collections.Generic;
using System.Text;

namespace schoolTracker
{
    // Implement Object-Oriented.
    // Derived class of Teacher inherits from one Base class of SchoolMember.
    // Inherits from and implements IPayee interface class.
    class Teacher : SchoolMember, IPayee
    {

        // Initialise fields.
        // public string Name;
        // public string Address;
        // public int Phone;
        public string Subject;
        public string Class;

        public void Pay()
        {
            Console.WriteLine("Paying teacher");
        }
    }
}
