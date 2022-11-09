using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentQue_25
{
    public class DoWhile
    {
        public void looping()
        {
            string[] arr = { "apple", "banana", "cherry" };
            int index = 0;

            do
            {
                Console.WriteLine(arr[index]);
                index++;
            } while (index < arr.Length);
        }

    }
}

