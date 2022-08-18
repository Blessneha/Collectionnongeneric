using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection1
{
    internal class Accept10
    {

       static public void accept()
        {
            ArrayList arrayList = new ArrayList(10);
            Console.WriteLine("Enter 10 values: ");
            for(int i=0;i<10;i++)
            {
                int s=Convert.ToInt32(Console.ReadLine());
                arrayList.Add(s);
                

            }
            arrayList.Sort();
            foreach(int i in arrayList)
            {
                Console.WriteLine(i);
            }
        }

    }
}
