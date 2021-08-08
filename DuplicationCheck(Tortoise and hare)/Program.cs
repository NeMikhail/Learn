using System;

namespace DuplicationCheck_Tortoise_and_hare_
{
    class Program
    {
        static void Main()
        {
            int[] nums = new int[10] {1, 5, 4, 7, 6, 3, 9, 4, 0, 8 };
            int tortoise = 0;
            int hare = 0;
            Console.WriteLine("1, 5, 4, 7, 6, 3, 9, 4, 0, 8");
            while (true)
            {
                tortoise = nums[tortoise];
                hare = nums[nums[hare]];
                if (tortoise == hare)
                    break;
            }
            int ptr1 = nums[0];
            int ptr2 = tortoise;
            while (ptr1 != ptr2)
            {
                ptr1 = nums[ptr1];
                ptr2 = nums[ptr2];
            }
            Console.WriteLine(tortoise + " " + hare);
            Console.WriteLine(ptr1);
            Console.ReadKey();
        }
    }
}
