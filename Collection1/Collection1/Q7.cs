using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection1
{
    internal class Q7
    {

        public int sid;
        public string name;

    }

    public class Stuadd
    {
        public void st1()
        {   ArrayList a=new ArrayList();
            Console.WriteLine("Enter the no of student details to add: ");
            int y=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<y;i++)
            {
                Q7 q7 = new Q7();
                q7.sid = Convert.ToInt32(Console.ReadLine());
                q7.name = Console.ReadLine();
                a.Add(q7);
            }

            foreach (Q7 q in a)
            {
                Console.WriteLine($"{q.sid} and{q.name}");
            }
        }
    }
}
