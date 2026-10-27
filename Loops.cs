using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


class Loops
{
    public static void Run()
    {
        //1]for loop - write code where your name repeat 5 times
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("kunjal");
        }

        //2]While loop - Use it when repetition depends on a condition.
        int n = 1;
        while (n <= 5)
        {
            Console.WriteLine(n);
            n++;
        }

        //3]do-while loop - A do-while loop executes the body at least once, even if the condition is false.
        int m = 1;
        do
        {
            Console.WriteLine(m);
            m++;
        }
        while (m <= 5);

        //4]foreach loop - Use it to visit each item in an array or collection.
        string[] names = { "Kunjal", "Kavya", "Riya" };
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        /*5]Nested loops -A nested loop is a loop inside another loop.
        You'll use it for star patterns, number patterns, and multiplication tables.*/

        for (int p = 1; p <= 3; p++)
        {
            for (int k = 1; k <= 3; k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        //Break statement - break stops the loop immediately.
        for (int i = 1; i <= 10; i++)
        {
            if (i == 6)
            {
                break;
            }
            Console.WriteLine(i);
        }

        //Continue statement - continue skips the current iteration and moves to the next one.
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }
}

