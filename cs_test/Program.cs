﻿using System;

namespace cs_test
{
    class Program
    {
        static void Main(string[] args)
        {
            static void StringModification()
            {
                string nameConcat = string.Concat("My ", "name ", "is ", "John");
                Console.WriteLine(nameConcat);

                nameConcat = string.Join(" ", "My", "name", "is", "John");
                Console.WriteLine(nameConcat);

                nameConcat = "My " + "name " + "is " + "John";

                //string newName = 
                nameConcat = nameConcat.Insert(0, "By the way, ");
                Console.WriteLine(nameConcat);

                nameConcat = nameConcat.Remove(0, 1);
                Console.WriteLine(nameConcat);

                string replaced = nameConcat.Replace('n', 'z');
                Console.WriteLine(replaced);

                string data = "12;28;34;25;64";
                string[] spliData = data.Split(';');
                string first = spliData[0];
                Console.WriteLine(first);

                char[] chars = nameConcat.ToCharArray();
                Console.WriteLine(chars[0]);
                Console.WriteLine(nameConcat[0]);

                string lower = nameConcat.ToLower();
                Console.WriteLine(lower);

                string upper = nameConcat.ToUpper();
                Console.WriteLine(upper);

                string john = " ";
                Console.WriteLine(john.Trim());
            }

            static void StringEmptiness()
            {
                string str = string.Empty; //same as ""

                string empty = "";
                string whiteSpaced = " ";
                string notEmpty = " b";
                string nullString = null;

                Console.WriteLine("IsNullOrEmpty");
                bool isNullOrEmpty = string.IsNullOrEmpty(nullString);
                Console.WriteLine(isNullOrEmpty);

                isNullOrEmpty = string.IsNullOrEmpty(whiteSpaced);
                Console.WriteLine(isNullOrEmpty);

                isNullOrEmpty = string.IsNullOrEmpty(notEmpty);
                Console.WriteLine(isNullOrEmpty);

                isNullOrEmpty = string.IsNullOrEmpty(empty);
                Console.WriteLine(isNullOrEmpty);

                Console.WriteLine();
                Console.WriteLine("IsNullOrWhiteSpace");

                bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(nullString);
                Console.WriteLine(isNullOrWhiteSpace);

                isNullOrWhiteSpace = string.IsNullOrWhiteSpace(whiteSpaced);
                Console.WriteLine(isNullOrWhiteSpace);

                isNullOrWhiteSpace = string.IsNullOrWhiteSpace(notEmpty);
                Console.WriteLine(isNullOrWhiteSpace);

                isNullOrWhiteSpace = string.IsNullOrWhiteSpace(empty);
                Console.WriteLine(isNullOrWhiteSpace);
            }

            static void QueryingStrings()
            {
                string name = "abracadabra";
                bool containsA = name.Contains('a');
                bool containsE = name.Contains('E');

                Console.WriteLine(containsA);
                Console.WriteLine(containsE);

                bool endsWithAbra = name.EndsWith("abra");
                Console.WriteLine(endsWithAbra);

                bool startsWithAbra = name.StartsWith("abra");
                Console.WriteLine(startsWithAbra);

                int indexOfA = name.IndexOf('a', 1);
                Console.WriteLine(indexOfA);

                int lastIndexOfR = name.LastIndexOf('r');
                Console.WriteLine(lastIndexOfR);

                Console.WriteLine(name.Length);

                string substrFrom5 = name.Substring(5);
                string substrFromTo = name.Substring(0, 3);

                Console.WriteLine(substrFrom5);
                Console.WriteLine(substrFromTo);
            }

            static void StaticAndInstanceMembers()
            {
                string name = "abracadabra";
                bool containsA = name.Contains('a');
                bool containsE = name.Contains('E');

                Console.WriteLine(containsA);
                Console.WriteLine(containsE);

                string abc = string.Concat("a", "b", "c");
                Console.WriteLine(abc);

                Console.WriteLine(int.MinValue);

                int x = 1;
                string xStr = x.ToString();
                Console.WriteLine(xStr);
                Console.WriteLine(x);
            }

            static void ComparisonOperators()
            {
                int x = 1;
                int y = 2;

                bool areEqual = x == y;
                Console.WriteLine(areEqual);

                bool result = x > y;
                Console.WriteLine(result);

                result = x >= y;
                Console.WriteLine(result);

                result = x < y;
                Console.WriteLine(result);

                result = x <= y;
                Console.WriteLine(result);

                result = x != y;

                Console.WriteLine(result);
            }

            static void MathOperations()
            {
                int x = 1;
                int y = 2;

                int z = x + y;
                int k = x - y;
                int a = z + k - y;

                Console.WriteLine(z);
                Console.WriteLine(k);
                Console.WriteLine(a);

                int b = z * 2;
                int c = k / 2;

                Console.WriteLine(b);
                Console.WriteLine(c);

                a = 4 % 2;
                b = 5 % 2;

                Console.WriteLine(a);
                Console.WriteLine(b);

                a = 3;
                a = a * a;
                //a = a * a * a;
                Console.WriteLine(a);

                a = (2 + 2) * 2;
                Console.WriteLine(a);
                a *= 2;
                //a = a * 2
                Console.WriteLine(a);
                a /= 2;
                //a = a / 2
                Console.WriteLine(a);
            }

            static void IncrementDecrementDemo()
            {
                int x = 1;
                x = x + 1;
                Console.WriteLine(x);

                x++;
                Console.WriteLine(x);

                ++x;
                Console.WriteLine(x);

                x = x - 1;
                x--;
                --x;

                Console.WriteLine(x);

                Console.WriteLine("Learn about increments");
                Console.WriteLine($"Last x state is {x}");

                int j = x++;
                Console.WriteLine(j);
                Console.WriteLine(x);

                j = ++x;
                Console.WriteLine(j);
                Console.WriteLine(x);

                x += 2;
                // x = x + 2
                Console.WriteLine(x);

                j -= 2;
                //j = j - 2
                Console.WriteLine(j);
            }

            static void MathDemo()
            {
                Console.WriteLine(Math.Pow(2, 3));
                Console.WriteLine(Math.Sqrt(9));
                Console.WriteLine(Math.Sqrt(8));

                Console.WriteLine(Math.Round(1.7));
                Console.WriteLine(Math.Round(1.4));

                Console.WriteLine();

                Console.WriteLine(Math.Round(2.5));
                Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
                Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven));
            }

            static void Overflow()
            {
                checked
                {
                    uint x = uint.MaxValue;

                    Console.WriteLine(x);

                    x = x + 1;

                    Console.WriteLine(x);

                    x = x - 1;

                    Console.WriteLine(x);
                }
            }

            static void VariablesScope()
            {
                var a = 1;
                {
                    var b = 2;
                    {
                        var c = 3;
                        Console.WriteLine(a);
                        Console.WriteLine(b);
                        Console.WriteLine(c);
                    }
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    //Console.WriteLine(c);
                }
                Console.WriteLine(a);
                //Console.WriteLine(b);
                //Console.WriteLine(c);
            }

            static void Literals()
            {
                int x = 0b11;
                int y = 0b1001;
                int k = 0b10001001;
                int m = 0b1000_1001;

                Console.WriteLine(x);
                Console.WriteLine(y);
                Console.WriteLine(k);
                Console.WriteLine(m);

                x = 0x1F;
                y = 0xFF0D;
                k = 0x1FAB30EF;
                m = 0x1FAB_30EF;

                Console.WriteLine();

                Console.WriteLine(x);
                Console.WriteLine(y);
                Console.WriteLine(k);
                Console.WriteLine(m);

                Console.WriteLine();

                Console.WriteLine(4.5e2);
                Console.WriteLine(3.1E-1);

                Console.WriteLine();

                Console.WriteLine('\x78');
                Console.WriteLine('\x5A');

                Console.WriteLine('\u0420');
                Console.WriteLine('\u0421');
            }

            static void Variables()
            {
                int x = -1;

                int y;
                y = 2;

                //Int32 x1 = -1;

                //uint z = -1;

                float f = 1.1f;

                double d = 2.3;

                int x2 = 0;
                int x3 = new int();

                var a = 1;
                var b = 1.2;

                //Dictionary<int, string> dict = new Dictionary<int, string>();
                //var dict = new Dictionary<int, string>();

                //var v;

                decimal money = 3.0m;

                char @char = 'A';
                string name = "John";

                bool canDrive = true;
                bool canDraw = false;

                object obj1 = 1;
                object obj2 = "obj2";

                Console.WriteLine(a);
                Console.WriteLine(name);
            }
            static void DateTimeIntro()
            {
                DateTime now = DateTime.Now;
                Console.WriteLine(now.ToString());

                Console.WriteLine($"It's {now.Date}, {now.Hour}:{now.Minute}");

                DateTime dt = new DateTime(2016, 2, 28);
                DateTime newDt = dt.AddDays(1);

                Console.WriteLine(newDt);

                TimeSpan ts = now - dt;
                //ts = now.Subtract(dt);
                Console.WriteLine(ts.Days);
            }

            static void IntroToArrays()
            {
                int[] a1;
                a1 = new int[10];

                int[] a2 = new int[5];

                int[] a3 = new int[5] { 1, 3, -2, 5, 10 };

                int[] a4 = { 1, 3, 2, 4, 5 };

                Console.WriteLine(a4[0]);

                int number = a4[4];
                Console.WriteLine(number);

                a4[4] = 6;
                Console.WriteLine(a4[4]);

                Console.WriteLine(a4.Length);
                Console.WriteLine(a4[a4.Length - 1]);

                string s1 = "abcdefgh";
                char first = s1[0];
                char last = s1[s1.Length - 1];

                Console.WriteLine($"First:{first}. Last:{last}");

                //impossible
                //s1[0] = 'z';
            }



            static void Comments()
            {
                //a single-line comment

                /*
                 * Multi-line comment
                 * We can write here many words
                 */

                //describe hows and whys! not whats!

                int a = 1;

                //increment a by 1 - bad comment, this code is self-evident

                //we need to tweak the index to match the expected outcome
                a++;
            }

            static void CastingAndParsing()
            {
                byte b = 3; // 0000 0011
                int i = b; // 0000 0000 0000 0000 0000 0000 0000 0011
                long l = i; // 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011

                float f = i; //3.0

                //Console.WriteLine(f);

                b = (byte)i;
                //Console.WriteLine(b);

                i = (int)f;
                //Console.WriteLine(i);

                f = 3.1f;
                i = (int)f;
                //Console.WriteLine(i);

                string str = "1";
                //i = (int)str;
                i = int.Parse(str);
                //Console.WriteLine($"Parsed i={i}");

                int x = 5;
                int result = x / 2;
                Console.WriteLine(result);

                double result2 = (double)x / 2;
                Console.WriteLine(result2);
            }
        }
    }
}