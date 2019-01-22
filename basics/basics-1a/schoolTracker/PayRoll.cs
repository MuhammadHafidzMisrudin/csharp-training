using System;
using System.Collections.Generic;
using System.Text;

namespace schoolTracker
{
    // Add an interface of payment system.
    interface IPayee
    {
        void Pay();
    }


    class PayRoll
    {
        List<IPayee> payees = new List<IPayee>();

        //Teacher teacher1 = new Teacher();
        //Teacher teacher2 = new Teacher();
        //Principal principal = new Principal();

        // Constructor to initialise the instances of Teachers and Princi[als. 
        // Then add them to the list of payees.
        public PayRoll()
        {
            //List<IPayee> payees = new List<IPayee>();
            payees.Add(new Teacher());
            payees.Add(new Teacher());
            payees.Add(new Principal());
        }

        // Add a method to pay for Teachers and Principal(s).
        public void PayAll()
        {
            foreach (var payee in payees)
            {
                payee.Pay();
            }
        }
    }
}
