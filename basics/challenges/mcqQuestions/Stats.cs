using System;
using System.Collections.Generic;
using System.Text;

namespace mcqQuestions
{
    class Stats
    {
        public void Start()
        {
            Program.Posted += HasPosted;
        }

        void HasPosted()
        {
            Console.WriteLine("\nSurvey posted, run stats.");
        }
    }
}
