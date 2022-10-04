using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7
{
    class Program
    {
        static void Q1()
        {
            Console.WriteLine("Enter a string : ");
            string word = Console.ReadLine();
            for(int i=0;i<word.Length;i++)
            {
                if (i==0)
                {
                    Console.Write(word[word.Length - i - 1]);
                }
                else
                {
                    if (i == word.Length - 1)
                    {
                        Console.Write(word[0]);
                    }
                    else
                    {
                        Console.Write(word[i]);
                    }
                }
               
            }
        }
        static void Q2()
        {
            int[] sequence = { 3, 4, 5 };
            int[] a1 = { 7, 5, 2, 3, 4, 5, 0, 9, 9 };
            int []a2 = { 5, 3, 8, 9 };
            PrintArray(sequence);
            PrintArray(a1);
            Console.WriteLine("The sequence is present : " + Appearance(a1, sequence));
            PrintArray(a2);
            Console.WriteLine("The sequence is present : " + Appearance(a2, sequence));
        }

        static bool Appearance(int []a, int[]sequence)
        {
            bool answer=false;
            for(int i=0; i<a.Length;i++)
            {
                if (a[i]== sequence[0])
                {
                    for (int j = 1; j < sequence.Length; j++)
                    {
                        if(a[i+j] == sequence[j])
                        {
                            answer = true;
                        }
                        else
                        {
                            answer = false;
                        }

                    }
                }
            }
            return answer;
        }

        static void PrintArray(int []a)
        {
            for(int i=0; i<a.Length;i++)
            {
                Console.Write(a[i] + "\t");
            }
            Console.WriteLine();
        }
        static void Q3_a()
        {
            Console.WriteLine("Enter a character : ");
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("ASCII :"+Convert.ToInt32(c));
        }

        static void Q3()
        {
            Console.WriteLine("Enter your array of character");
            string a = Console.ReadLine();
            //char[] sort = new char[a.Length];
            for(int i=0;i<a.Length;i++)
            {
                for (int j = 0; j < a.Length-1; j++)
                {
                    if (Convert.ToInt32(a[j])< Convert.ToInt32(a[j+1]))
                    {
                        
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //Q1();
            //Q2();
            //Q3_a();
            Q3();
            Console.ReadKey();
        }
    }
}
