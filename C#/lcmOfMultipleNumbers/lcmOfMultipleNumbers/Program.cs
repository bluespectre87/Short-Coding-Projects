using System;
using System.Collections.Generic;

namespace lcmOfMultipleNumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] nums = {1,2,3};
            List<int> mult1 = new List<int>();
            List<int> mult2 = new List<int>();
            List<int> mult3 = new List<int>();
            int tempCounter = 1 ;
            bool commonFOund = false;
            int lcm = 0;
            bool lcmFound = false;
            int tempCommon = 0;

            while (lcmFound == false)
            {
                mult1.Add(nums[0] * tempCounter);
                mult2.Add(nums[1] * tempCounter);
                mult3.Add(nums[1] * tempCounter);

                foreach (var multiple in mult1)
                {
                    for (int i = 0; i < mult2.Count; i++)
                    {
                        if (mult2[i] == multiple)
                        {
                            commonFOund = true;
                            tempCommon = multiple;
                        }
                    }
                }

                if (commonFOund == true)
                {
                    foreach (var item in mult3)
                    {
                        if (item == tempCommon)
                        {
                            lcmFound = true;
                            lcm = item;
                        }
                        else
                        {
                            lcmFound = false;
                        }
                    }
                }

                if(lcmFound == false)
                {
                    tempCounter += 1;
                }


            }
            

            Console.WriteLine("LCM: {0}", lcm);

            Console.Read();
        }
    }
}
