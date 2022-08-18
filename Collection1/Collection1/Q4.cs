using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection1
{
    internal class Q4
    {
        static public void sol4()
        {
            ArrayList arr=new ArrayList();
            Console.WriteLine("Enter the no of names to add");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the names: ");
            for(int i=0;i<n;i++)
            {
                string res=Console.ReadLine();
                arr.Add(res);

            }
            arr.Sort();
            arr.Reverse();

            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }

        }
    }
}
