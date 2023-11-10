using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //byte age = 21;
            //Console.WriteLine(age);
            //Console.WriteLine("Hi");
            //Console.ReadLine();
            DataSet set = new DataSet();
            DataTable table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Name");
            
            for(int i = 0; i < 2; i++)
            {
                table.Rows.Add("1", "Praful");
                //table.Rows.Add("2", "Kailash");
            }


            foreach(DataRow r in table.Rows)
            {
                Console.WriteLine(r["Id"] + " " + r["Name"]);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
