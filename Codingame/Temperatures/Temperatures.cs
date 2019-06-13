using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Temperatures
{
    static void Main(string[] args)
    {
        try
        {
            int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
            if (n >= 10000)
                throw new Exception();
            string[] inputs = Console.ReadLine().Split(' ');
            int[] tabTemp = new int[n];
            for (int i = 0; i < n; i++)
            {
                int t = int.Parse(inputs[i]); // a temperature expressed as an integer ranging from -273 to 5526
                if (t < -273 || t > 5526)
                    throw new Exception();
                else
                    tabTemp[i] = t;
            }
            int minT = tabTemp[0];
            foreach (int t in tabTemp)
                if (Math.Abs(t) < Math.Abs(minT))
                    minT = t;
                else if (Math.Abs(t) == Math.Abs(minT) && t > 0)
                    minT = t;


            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(minT);
            Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine(0);
        }
    }
}