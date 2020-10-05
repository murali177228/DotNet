using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array list
            ArrayList myArryList = new ArrayList();// Recommended
            // or - with some limitations
            IList arryList1 = new ArrayList();
            arryList1.Add(1);
            arryList1.Add("Two");
            arryList1.Add(3);
            arryList1.Add(4.5);
            // or - with some limitations
            ICollection myArryList2 = new ArrayList();
            // or - with some limitations
            IEnumerable myArryList3 = new ArrayList();
            for(int i=0;i<=100;i++)
            {
                myArryList.Add(i);
                Console.WriteLine(myArryList[i]);
            }
            foreach(var l in arryList1)
            {
                Console.WriteLine(l);
            }

            Console.WriteLine(myArryList.Count);

            arryList1.Insert(2, "Murali");
            foreach (var l in arryList1)
            {
                Console.WriteLine(l);
            }

        }
    }
}
