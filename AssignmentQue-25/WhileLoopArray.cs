using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentQue_25
{
    public class Looping
    {
        public void loop()
        {


            string[] arr = { "apple", "banana", "cherry" };
            int index = 0;
            while (index < arr.Length)
            {
                Console.WriteLine(arr[index]);
                index++;
            }
        }
    }
}
