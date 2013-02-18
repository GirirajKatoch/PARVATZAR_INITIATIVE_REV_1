using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingArray
{
    //Demonstrate Algorithms of Class Array
    public class UsingArray
    {
        private static int[] intValues = { 1, 2, 3, 4, 5, 6 };
        private static double[] doubleValues = {8.4,9.3,0.2,7.9,3.4};
        private static int[] intValuesCopy;
        static void Main(string[] args)
        {
            intValuesCopy = new int[intValues.Length];
            Console.WriteLine("Initial array values:\n");
            PrintArrays(); //output array contents;
            //sort doubleValues;
            Array.Sort(doubleValues);
            //copy intValues to intValuesCopy;
            Array.Copy(intValues, intValuesCopy,intValues.Length);
            Console.WriteLine("\nArray values after Sort and Copy:\n");
            PrintArrays(); //output Array Contents;
            Console.WriteLine();

        }
        private static void PrintArrays()
        {
            Console.WriteLine("doubleValues:  ");
            //iterate through the double array with an enumerator
            IEnumerator enumerator = doubleValues.GetEnumerator();
            while (enumerator.MoveNext())
                Console.WriteLine(enumerator.Current + " ");
            Console.WriteLine("\nintValues:  ");
            //iterate through an int array with an enumerator
            enumerator = intValues.GetEnumerator();
            while (enumerator.MoveNext())
                Console.WriteLine(enumerator.Current + " ");
            Console.WriteLine("\nintValuesCopy: ");
            //iterate through the second int array with a foreach statement;
            foreach (var element in intValuesCopy)
                Console.WriteLine(element + "  ");
            Console.WriteLine();
        } //end method PrintArrays
    }
}
