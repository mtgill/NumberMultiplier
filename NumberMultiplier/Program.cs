using System;
using System.Collections.Generic;

namespace NumberMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a list of comma seperated numbers");

            var numInputs = Console.ReadLine();

            var numList = numInputs.Split(",");

            List<int> myNums = new List<int>();

            for (var i = 0; i < numList.Length; i++)
            {
                myNums.Add(int.Parse(numList[i]));
            }

            Console.WriteLine("Would you like to multiply them together or square each value?");
            var mathType = Console.ReadLine();
            mathType.ToLower();

            if (mathType == "multiply")
            {
                int currentVal = 1;

                for (var i = 0; i < myNums.Count; i++)
                {
                    currentVal = currentVal * myNums[i];
                }

                Console.Write(currentVal.ToString());
                return;
            } else if (mathType == "square")
            {
                int sqrdVal;

                for (var i = 0; i < myNums.Count; i++)
                {
                    var currentVal = myNums[i];
                    sqrdVal = currentVal * currentVal;
                    sqrdVal.ToString();
                    Console.Write($"{sqrdVal},");
                }
            } else
            {
                Console.WriteLine("Better luck next time!");
            }

        }
    }
}
