using System;
using System.Collections.Generic;
using System.Text;

namespace schoolTracker
{
    // Derived class of Principal inherits from one Base class of SchoolMember.
    // Inherits from and implements IPayee interface class.
    class Principal : SchoolMember, IPayee
    {
        public void Pay()
        {
            Console.WriteLine("Paying principal");
        }
    }
}
