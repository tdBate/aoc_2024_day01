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
        static void part1()
        {
            List<int> bal = new List<int>();
            List<int> jobb = new List<int>();

            string[] lines = File.ReadAllLines("../../input.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Replace("\n", "").Replace("   ", ";").Split(';');
                bal.Add(int.Parse(parts[0]));
                jobb.Add(int.Parse(parts[1]));
            }

            int osszeg = 0;

            bal.Sort();
            jobb.Sort();

            for (int a = 0; a < bal.Count; a++)
            {
                //Console.WriteLine(bal[a]);

                osszeg += Math.Abs(bal[a] - jobb[a]);
            }


            Console.WriteLine(osszeg);
        }


        static void Main(string[] args)
        {
            //part1();

            List<int> bal = new List<int>();
            List<int> jobb = new List<int>();

            string[] lines = File.ReadAllLines("../../input.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Replace("\n", "").Replace("   ", ";").Split(';');
                bal.Add(int.Parse(parts[0]));
                jobb.Add(int.Parse(parts[1]));
            }
            bal.Sort();
            jobb.Sort();

            Console.ReadKey();
        }
    }
}
