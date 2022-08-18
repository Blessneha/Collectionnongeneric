using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection1
{
    internal class Q5
    {
        static public void sol5()
        {
            int empc;
            string emplname;
            SortedList srt=new SortedList();

            Console.WriteLine("Enter the number of the list: ");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the values: ");
            for(int i=0;i<n;i++)
            {
                empc=Convert.ToInt32(Console.ReadLine());
                emplname=Console.ReadLine();
                srt.Add(empc,emplname);
            }

            foreach(DictionaryEntry pair in srt)
            {
                Console.WriteLine("{0} and {1}",pair.Key,pair.Value);
            }

        }
    }
}
