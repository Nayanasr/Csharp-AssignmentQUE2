using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentQue_25
{
   
        public class My_Family
        {

            public virtual void member()
            {
                Console.WriteLine("Total number of family members: 3");
            }
        }

        // Derived Class
        public class My_Member : My_Family
        {
            // Re implement the method of the base class
            // Using new keyword
            // It hides the method of the base class
            public new void member()
            {
                Console.WriteLine("Name: Rakesh, Age: 40 \nName: Somya, " +
                                       "Age: 39 \nName: Rohan, Age: 20 ");
            }
        }
}

//C# also provides a concept to hide the methods of the base class from 
//derived class, this concept is known as Method Hiding.It is also known
//as Method Shadowing.
//In method hiding, you can hide the implementation of the methods of 
//a base class from the derived class using the new keyword.

