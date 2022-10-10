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
            int [] nb=new int [a.Length];
            for(int i=0;i< a.Length; i++)
            {
                nb[i] = Convert.ToInt32(a[i]);
            }
            for(int i=0;i<nb.Length;i++)
            {
                for (int j = 0; j < nb.Length-1; j++)
                {
                    if (Convert.ToInt32(nb[j]) < Convert.ToInt32(nb[j + 1]))
                    {
                        int temp = nb[j];
                        nb[j] = nb[j + 1];
                        nb[j + 1] = temp;
                    }
                }
                
            }
            Console.WriteLine("Array sorted : \n");
            for (int i = 0; i < nb.Length; i++)
            {
                Console.Write(Convert.ToChar(nb[i]));
            }
        }

        static void Q4()
        {
            string s1= "kkkktttrrrrrrrrrr";
            string s2 = "p555ppp7www";

            Console.WriteLine(s1 + "\nCompressed forma: " + Count(s1));
            Console.WriteLine(s2 + "\nCompressed forma: " + Count(s2));
        }
        static string Count(string s)
        {
            string repetition = null;
            int nb = 1;
            for (int i = 0; i < s.Length-1 ; i++)
            {
                if(s[i]==s[i+1])
                {
                    nb = nb + 1;
                }
                else
                {
                    repetition = repetition + s[i] + nb.ToString();
                    nb = 1;
                }
            }
            repetition = repetition + s[s.Length-1] + nb.ToString();
            return repetition;
        }
        static void Q5()
        {
            int nb = 0;
            for(int i=0;i<1000;i++)
            {
                if(Three_Digit(i)==true)
                {
                    nb++;
                    Console.WriteLine("Armstrong number " + nb + " : " + i);
                }
            }
        }

        static bool Three_Digit(int nb)
        {
            bool answer = false;
            int quotient = nb;
            int calcul = 0;
            int p = 2;
            while(quotient>0)
            {
                int remainder = (int)(quotient % Math.Pow(10, p));
                quotient = (int)(quotient / Math.Pow(10, p));
                calcul = calcul + (int)Math.Pow(quotient, 3);
                //Console.WriteLine(remainder + " " + quotient + " " + calcul);
                quotient = remainder;
                p--;
            }
            if(nb==calcul)
            {
                answer = true;
            }
            return answer;
        }

        static void Q6()
        {
            int [] a = { 5, 7, 5, 2, 2, 4, 5 };
            int nb = 0;
            int max=a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            for (int i = 0; i <= max; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] == i)
                    {
                        nb++;
                    }
                }
                if(nb!=0)
                {
                    Console.WriteLine(i + " is " + nb + " times ");
                }

                nb = 0;
            }

        }
        static void Q6_Bis()
        {
            int[] a = { 5, 7, 5, 2, 2, 4, 5 };
            int nb = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        nb++;
                    }
                    
                }
                Console.WriteLine(a[i] + " is " + nb + " times ");

                nb = 0;
            }

        }
        static void Q7()
        {
            Console.WriteLine("Enter a number : ");
            int nb = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for(int i=0; i<nb;i++)
            {
                factorial = factorial * (i+1);
            }
            Console.WriteLine(nb + "!=" + factorial);
        }
        static void Q8()
        {
            string phrase = "My name is Margaux !";
            char space = ' ';
            int nb = 0;
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] == space)
                {
                    nb++;
                }
            }
            Console.WriteLine(phrase);
            Console.WriteLine("Number of white spaces : " + nb);

        }
        static void Q9()
        {
            Console.WriteLine("Enter three names :");
            Person p1 = new Person(Console.ReadLine());
            Person p2 = new Person(Console.ReadLine());
            Person p3 = new Person(Console.ReadLine());
            Person[] persons = { p1, p2, p3 };
            Console.WriteLine("Your array of Person is : ");
            for(int i=0;i<persons.Length;i++)
            {
                Console.Write(persons[i].ToString()+ "\t");
            }
        }
        static void Main(string[] args)
        {
            //Q1();
            //Q2();
            //Q3_a();
            //Q3();
            //Q4();
            //Q5();
            //Q6();
            //Q6_Bis();
            //Q7();
            //Q8();
            Q9();
            Console.ReadKey();
        }
    }
}
