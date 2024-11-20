using System.Linq.Expressions;

namespace inclass_arrayindex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("find index problem");
            Console.WriteLine("how many elements in your array .");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
             string [] inputarray = EnterStringArray(arrayLength);
            Console.WriteLine("what is the target value");
            string targetvalue =  Console.ReadLine();
            Console.WriteLine();
            FindIndexOfTarget(inputarray, targetvalue);
            int indexValue = FindIndexOfTarget(inputarray, targetvalue); 
            
            Console.WriteLine(indexValue);  




           static string[] EnterStringArray(int arrayLength)
            {
                Console.WriteLine("input your array one element at a time");
                string[] inputArray = new string[arrayLength];
               

                for (int i = 0; i < inputArray.Length; i++)
                {
                    inputArray[i] = Console.ReadLine();
                }

                Console.WriteLine($"The array you entered is:");
                foreach (string input in inputArray)
                {
                    Console.Write(input + " ");
                }
                return inputArray;
            }
        }
        static int FindIndexOfTarget(string[] inputarray, string? targetValue) 
        {
            for (int i = 0;i < inputarray.Length; i++)
            {
               if( inputarray[i].Equals (targetValue))
                {
                    return i;
                    
                }
              
            }
            return -1;
        }
        
        
    }
}
