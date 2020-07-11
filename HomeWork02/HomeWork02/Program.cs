using System;

namespace HomeWork02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type conversions
            // Explicit conversion/cast examples
            // Example1: Cast double to integer
            double x = 159.52;
            int expNum1;
            expNum1 = (int)x;
            Console.WriteLine(expNum1);
            Console.WriteLine(expNum1.GetType());

            // Example2: Cast string to double
            string y = "33.21";
            double expNum2;
            expNum2 = Convert.ToDouble(y);
            Console.WriteLine(expNum2);
            Console.WriteLine(expNum2.GetType());

            // Example3: Cast ulong to ushort
            ulong z = 123456789;
            ushort expNum3;
            expNum3 = (ushort)z;
            Console.WriteLine(expNum3);
            Console.WriteLine(expNum3.GetType());

            // Implicit conversion examples
            // Example1: convert byte to short
            byte a = 255;
            short impNum1 = a;
            Console.WriteLine(impNum1);
            Console.WriteLine(impNum1.GetType());

            // Example2: convert ulong to decimal
            ulong b = 18446;
            decimal impNum2 = b;
            Console.WriteLine(impNum2);
            Console.WriteLine(impNum2.GetType());

            // Example3: convert float to double
            float c = 134.45E-2f;
            double impNum3 = c;
            Console.WriteLine(impNum3);
            Console.WriteLine(impNum3.GetType());

            // Boxing/Unboxing examples
            // Example1
            int d = 235;
            object obj1 = d;//boxing
            d = (int)obj1;//unboxing
            Console.WriteLine(d);
            Console.WriteLine(d.GetType());

            // Example2
            double e = 235.56;
            object obj2 = e;//boxing
            e = (double)obj2;//unboxing
            Console.WriteLine(e);
            Console.WriteLine(e.GetType());

            // Example3
            float f = 1.001f;
            object obj3 = f;//boxing

            f = 1234.5678F;
            Console.WriteLine("The value-type value = {0}", f);
            Console.WriteLine(f.GetType());
            Console.WriteLine("The object-type value = {0}", obj3);
            Console.WriteLine(obj3.GetType());

            obj3 = 0.42F;
            f = (float)obj3;//unboxing
            Console.WriteLine(f);
            Console.WriteLine(f.GetType());

            // Boxing/Unboxing to different types examples
            // Boxing to int and unboxing to ushort
            int num1 = 78923;
            object o1 = num1; // boxing to int
            Console.WriteLine(num1);
            Console.WriteLine(num1.GetType());

            ushort num2 = (ushort)(int)o1; // unboxing to ushort
            Console.WriteLine(num2);
            Console.WriteLine(num2.GetType());

            // Boxing to char and unboxing to int
            char ch = 'a';
            object o4 = ch; // boxing to char
            Console.WriteLine(ch);
            Console.WriteLine(ch.GetType());

            int ch2i = (int)(char)o4; // unboxing to int
            Console.WriteLine(ch2i);
            Console.WriteLine(ch2i.GetType());
        }
    }
}