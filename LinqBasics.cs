using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQWithSimpleTypeArray
{
    class Program
    {
        static void Main(string[] args)
        {   //Create Integer Array
            int[] values = { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };
            //Display Original values
            Console.WriteLine("Original Array:");
            foreach (var element in values)
                Console.WriteLine(" {0}", element);
            // LINQ query that obtains value greater than 4 from array
            var filtered =
            /*We do not specify the range variable’s type (here value is the range variable). Since it is assigned one 
            element at a time from the array values, which is an int array, the compiler determines that the range 
            variable value should be of type int. This is a C# feature called implicitly typed local variables, 
            which enables the compiler to infer a local variable’s type based on the context in which it’s used.*/
                from  value in values
                where value > 4
                select value;
            Console.WriteLine("\nValues greater than 4:");
            foreach (var element in filtered)
                Console.WriteLine(" {0}", element);
            //LINQ query to sort the elements of array
            var sorted =
                from value in values
                orderby value
                select value;
            Console.WriteLine("\n The sorted Array elements:\n");
            foreach (var element in sorted)
                Console.WriteLine(" {0}", element);


        }
    }
}
