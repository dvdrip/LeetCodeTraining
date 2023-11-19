// See https://aka.ms/new-console-template for more information

using System.ComponentModel;

Console.WriteLine("Hello, World!");

int[] testArray = { 2, 5, 5, 11 };
int testNum = 10;

consumeArrayAndNum(testArray, testNum);

void consumeArrayAndNum(int[] testArray, int testNum)
{
    for (int i = 0; i < testArray.Length; i++)
    {
        //Console.WriteLine("Array A: " + testArray[i]);

        for (int j = 1; j < testArray.Length; j++)
        {
            //Console.WriteLine("Array B: " + testArray[j]);

            int a = testArray[i];
            int b = testArray[j];
            int c = 0;

            //var index1 = Array.IndexOf(testArray, a);

            //var index2 = Array.IndexOf(testArray, b);

            if (i != j)
            {
                c = a + b;
            }

            //c = testArray[i] + testArray[j];

            if (c == testNum)
            {
                Console.WriteLine("The numbers are " + a + " and " + b + ", The target was " + c + ". The index were " + testArray[i] + " and " + testArray[j] );
            }

        }

    }
}