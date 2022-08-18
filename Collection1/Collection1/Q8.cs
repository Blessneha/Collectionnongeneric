using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection1
{
    internal class Q8
    {
        public string[] empname;
        public string des;
    }

    public class Emp
    {
        public void sol8()
        {
            int n;
            ArrayList arrayList = new ArrayList();
            string[] design = { "Program Manager", "Project Manager", "Team Lead", "Senior Programmer", "Junior Programmer" };
            foreach (string str in design)
            {
                Console.WriteLine($"Enter the number of employees for{str}");
                n = Convert.ToInt32(Console.ReadLine());
                Q8 qr = new Q8();
                qr.empname = new string[n];
                for (int i = 0; i < n; i++)
                {
                    qr.empname[i] = Console.ReadLine();
                }
                qr.des = str;
                arrayList.Add(qr);

                
            }

            foreach (Q8 r in arrayList)
            {

                Console.Write(r.des);
                Console.Write(" : [");
                foreach (string s in r.empname)
                {
                    Console.Write(s + " ");
                }
                Console.WriteLine("]");



            }
        }
    }
}
