using System;

namespace CsharpDataStructure
{
    class Algoritms
    {
        public int BinarySearch(int[] numbers, int findNumber)
        {
            int arrayLength, startIndex, midIndex, endIndex, numPosition;

            arrayLength = numbers.Length;

            numPosition = -1;
            startIndex = 0;
            endIndex = arrayLength-1;

            while(endIndex >= startIndex)
            {
                midIndex = ((startIndex + endIndex) / 2);

                //midIndex +- 1 is done for skipping computational deadlocks
                //1, 2, 3, 4, 5, 6, 7, 8, 9
                //findinf 9 will fall in deadlock in 7th position
                
                if(findNumber == numbers[midIndex])
                {
                    numPosition = midIndex;
                    break;
                }
                else if(findNumber < numbers[midIndex])
                {
                    endIndex = midIndex-1;
                }
                else
                {
                    startIndex = midIndex+1;
                }
            }


            return numPosition;
        }
        public int BinarySearchRecursive(int[] numbers, int findNumber, int startIndex, int endIndex)
        {
            //Console.WriteLine("length: {0} start: {1} end:{2}", numbers.Length, startIndex, endIndex);
            int midIndex;

            if (endIndex >= startIndex)
            {
                midIndex = (startIndex + endIndex) / 2;

                if (findNumber == numbers[midIndex])
                {
                    return midIndex;
                }

                else if (findNumber < numbers[midIndex])
                {
                    return BinarySearchRecursive(numbers, findNumber, 0, midIndex-1);
                }
                else
                {
                    return BinarySearchRecursive(numbers, findNumber, midIndex+1, endIndex);
                }
            }
            return -1;
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            /*
             Shortcut for inline commenting
             >>to comment: crtl+k+c
             >>to uncomment: ctrl+k+u
            */

            //THIS IS ONE OF THE WAY TO INPUT AN ARRAY
            /*
            int num_size, i;
            string []input_str;

            //Read Input
            Console.Write("How many numbers?: ");
            num_size = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[num_size];

            //Read The Numbers
            Console.Write("Please input {0} numbers: ", num_size);
            input_str = Console.ReadLine().Split(" ");

            //Make an array of ints'
            for(i=0; i<num_size; i++)
            {
                numbers[i] = Int32.Parse(input_str[i]);
            }

            Console.Write("The numbers are: ");
            for(i=0; i<num_size; i++)
            {
                Console.Write(" {0}", numbers[i]);
            }
            
            */

            //THIS IS THE SHORT WAY WAY TO INPUT AN ARRAY
            int i, arraySize, findNumber, findIndex;
            int[] numbers = { 2, 3, 4, 10, 40 };
            SearchAlgoritms searcherObj = new SearchAlgoritms();

            //Input array Formalities
            /*
            Console.Write("Input the numbers with a space: ");
            numbers = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

            arraySize = numbers.Length;
            
            Console.WriteLine("Size of the array: {0}", arraySize);

            Console.Write("The numbers are: ");
            for (i = 0; i < arraySize; i++)
            {
                Console.Write(" {0}", numbers[i]);
            }
            

            Console.Write("\nWhat number to find: ");
            findNumber = Convert.ToInt32(Console.ReadLine());
            */

            //TASK-------------------------------------------
            //Implement a sorting function in another project

            foreach (int tempNum in numbers)
            {
                //findIndex = searcherObj.BinarySearch(numbers, tempNum-1);
                findIndex = searcherObj.BinarySearchRecursive(numbers, tempNum, 0, numbers.Length - 1);
                Console.Write("\nNumber {0} in Position: {1}",tempNum, findIndex);
            }

            Console.ReadKey();


        }
    }
}
