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

        static void part2()
        {
            List<string> bal = new List<string>();
            List<string> jobb = new List<string>();

            string[] lines = File.ReadAllLines("../../input.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Replace("\n", "").Replace("   ", ";").Split(';');
                bal.Add((parts[0]));
                jobb.Add((parts[1]));
            }

            int osszeg = 0;
            int szamlalo = 0;
            for (int a = 0; a < bal.Count; a++)
            {
                szamlalo = 0;
                //Console.WriteLine(bal[a][2] );
                for (int b = 0; b < jobb.Count; b++)
                {
                    if (bal[a].Equals(jobb[b]))
                    {
                        szamlalo++;
                    }
                }
                osszeg += szamlalo * int.Parse(bal[a]);
            }
            Console.WriteLine(osszeg);
        }


        static void Main(string[] args)
        {
            part1();
            part2();
            
            Console.ReadKey();
        }

    }
}