using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection1
{
    internal class Q6
    {
        public string bookid;
        public string bookname;

        public void sol6()
        {
            Hashtable ha = new Hashtable();
            Console.WriteLine("Enter the number of details to be added: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                bookid = Console.ReadLine();
                bookname = Console.ReadLine();
                ha.Add(bookid, bookname);
            }

            foreach (DictionaryEntry d in ha)
            {
                Console.WriteLine("{0} and {1}", d.Key, d.Value);
            }


        }
    }  
}
