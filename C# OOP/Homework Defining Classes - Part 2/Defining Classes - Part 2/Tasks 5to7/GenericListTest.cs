using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_2.Tasks_5to7
{
    class GenericListTest
    {
        public static void TestGenericList()
        {
            Console.WriteLine("---- Testing Tasks 5,6 ----");
            var list = new GenericList<int>(3);
            list.AddElement(5);
            list.AddElement(10);
            list.AddElement(15);
            list.AddElement(20);
            Console.WriteLine($"list = {list}");
            list.RemoveElementByIndex(1);
            Console.WriteLine($"Eelemnt 1 removed. List = {list}");
            list.AddElement(2);
            Console.WriteLine($"Element 2 added. List = {list}");
            list.InsertElementAtIndex(1, 22);
            Console.WriteLine($"Element 22 added at index 1. List = {list}");
            list.ClearList();
            Console.WriteLine($"List cleared:{list}");

            Console.WriteLine("---- Testing Task 7 ----");
            list.InsertElementAtIndex(0, -5);
            list.InsertElementAtIndex(1, 0);
            list.InsertElementAtIndex(2, 5);
            list.InsertElementAtIndex(3, 10);
            Console.WriteLine($"list = {list}");
            Console.WriteLine($"list Min Value = {list.Min()}");
            Console.WriteLine($"list Max Value = {list.Max()}");
            var stringList = new GenericList<string>(3);
            stringList.AddElement("a");
            stringList.AddElement("cc");
            stringList.AddElement("bbb");
            Console.WriteLine($"stringList = {stringList}");
            Console.WriteLine($"stringList Min value = {stringList.Min()}");
            Console.WriteLine($"stringList Max value = {stringList.Max()}");
        }
    }
}
