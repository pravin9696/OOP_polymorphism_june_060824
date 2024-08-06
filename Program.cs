using System;

namespace OOP_polymorphism_june_060824
{
    class Encrypt
    {
        public string str { get; set; }
        public Encrypt()
        {

        }
        public Encrypt(string s1)
        {
            str = s1;
        }
        public void EncryptString()
        {
            char[] chArray = str.ToCharArray();

            //sort chArray in Asc order
            for (int i = 0; i < chArray.Length; i++)
            {
                for (int j = i + 1; j < chArray.Length; j++)
                {
                    if (chArray[i] > chArray[j])
                    {
                        char temp = chArray[i];
                        chArray[i] = chArray[j];
                        chArray[j] = temp;
                    }
                }
            }

            for (int i = 0; i < chArray.Length; i++)
            {
                Console.Write("\t" + chArray[i]);
            }
            Console.WriteLine();
            int cnt;
            for (int i = 0; i < chArray.Length; i++)
            {
                cnt = 1;
                int j;
                for ( j = i+1; j < chArray.Length; j++)
                {
                    if (chArray[i] == chArray[j])
                    {
                        cnt++;
                    }
                    else
                    {
                        //Console.WriteLine($"{chArray[i]} occurs {cnt} time");
                        
                        break;
                    }
                }
                Console.Write($"{chArray[i]}{cnt}");
                i = j - 1;
            }

        }
    }
    class Rectangle
    {
        public int length { get; set; }
        public int breadth { get; set; }

        //1
        public Rectangle()
        {
            length = 0;
            breadth = 0;
        }
        public Rectangle(int side)
        {
            length = side;
            breadth = side;
        }
        public Rectangle(int l, int b)
        {
            length = l;
            breadth = b;
        }
        public void CalculateArea()
        {
            int area = length * breadth;
            Console.WriteLine("Area of Rectangle is :" + area);
        }
    }
    class class1
    {
        public class1()
        {
            Console.WriteLine("constructor with 0 parameter called");
        }
        public class1(int x)
        {
            Console.WriteLine("constructor with 1 parameter called");
        }
        public class1(int a, int b)
        {
            Console.WriteLine("constructor with 2 parameter called");
        }

        public void sum(int x, int y)
        {
            int total = x + y;
            Console.WriteLine("total=" + total);
        }
        public void sum(string st1, string st2)
        {
            string st3 = st1 + st2;
            Console.WriteLine("string st3=" + st3);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //class1 obj = new class1();
            //obj.sum(111, 222);
            //obj.sum("abc", "xyz");
            Console.WriteLine("-------------------------");

            //Rectangle r1 = new Rectangle();//zero parameter constructor
            //r1.CalculateArea();
            //Rectangle r2 = new Rectangle(20);
            //r2.CalculateArea();
            //Rectangle r3 = new Rectangle(10,20);
            //r3.CalculateArea();

            Encrypt ecobj = new Encrypt("qdddddddabdacdaba");

            ecobj.EncryptString();

            Console.ReadKey();
        }
    }
}
