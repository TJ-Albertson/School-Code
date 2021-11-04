using System;
using System.Collections.Generic;

namespace Test_Workspace
{
    class Program
    {


        static void Main(string[] args)
        {

            List<int> myNumbers = new List<int>();

            for (int i = 1; i <= 10; i++) {
                myNumbers.Add(i);
            }

            foreach(int number in myNumbers){
                Console.WriteLine(number);
            }

            for(int index = 0; index < myNumbers.Count; index ++){
                Console.WriteLine(myNumbers[index]);
            }

        }
    }
}
