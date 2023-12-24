using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace KnowledgeCheckTwo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<ChildObject>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var myClass = new ChildObject();

                Console.WriteLine("Enter a value to be stored as a string: ");
                myClass.StringProperty = Console.ReadLine();

                Console.WriteLine("Enter a value to be stored as a double: ");
                myClass.DoubleProperty = Double.Parse(Console.ReadLine());

                Console.WriteLine("Enter a value - 'true' or 'false' - to be stored as a Boolean: ");
                myClass.BooleanProperty = bool.Parse(Console.ReadLine());

                Console.WriteLine("Enter a value to be stored as a floating-point number: ");
                myClass.FloatProperty = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter a value to be stored as a decimal: ");
                myClass.DecimalProperty = decimal.Parse(Console.ReadLine());

                recordList.Add(myClass);
            }

            // Print out the list of records using Console.WriteLine()
            for (int i = 0; i < numberOfRecords; i++)
            {
                Console.Write($"Record #{i + 1}: {recordList[i].StringProperty}; ");
                Console.Write($"{recordList[i].DoubleProperty}; {recordList[i].BooleanProperty}; ");
                Console.WriteLine($"{recordList[i].FloatProperty}; {recordList[i].DecimalProperty}");
            }
        }
    }
}