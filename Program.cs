using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace aoc_2024_day01
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<string> bal = new List<string>();
            List<string> jobb = new List<string>();

            string[] lines = File.ReadAllLines("../../input_fake.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Replace("\n", "").Replace("   ",";").Split(';');
                bal.Add(parts[0]);
                jobb.Add(parts[1]);
            }

            int osszeg = 0;

            //betűkre osztás
            int[] balelemek = new int[6];
            int[] jobelemek = new int[6];
            for (int a = 0; a < bal.Count; a++)
            {
                for (int b = 0; b < bal[a].Length; b++)
                {
                    Console.WriteLine(int.Parse(bal[a][b] + ""));
                    balelemek[b] = int.Parse(bal[a][b]+"");
                    jobelemek[b] = int.Parse(jobb[a][b]+"");
                }
                Array.Sort(balelemek);
                Array.Sort(jobelemek);

                for (int b = 0; b < bal[a].Length; b++)
                {

                    osszeg += Math.Abs(balelemek[b] - jobelemek[b]);
                    Console.WriteLine(balelemek[b]+" "+jobelemek[b]);
                    //Console.WriteLine();
                }
            }

            Console.WriteLine(osszeg);

            foreach (int elem in balelemek)
            {
                //Console.WriteLine(elem);
            }




            Console.ReadKey();
        }
    }
}
