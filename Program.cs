using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Schema;

namespace AlgorithmExercise
{
    class Program
    {
        private static string _line = "-------------------------------------------------";

        /* brauchen keinen Setter */
        public string Line
        { get { return _line; } }
        static void Main(string[] args)
        {
            int programmAuswahl = -1;
            do /* while (programmAuswahl != 0); */
            {
                Boolean bPointInRect = false;
                Console.WriteLine(bPointInRect);
                if (bPointInRect == true)
                    Console.WriteLine("Point lies within the Rect");

                Console.WriteLine("Auswahl des Algorithmus: ");
                Console.WriteLine("1: public static int Animals(int chickens, int cows, int pigs)");
                Console.WriteLine("2: public static float triangleArea(int b, int h))");
                Console.WriteLine("3: public static int GetAbsSum(int[] arr)");
                Console.WriteLine("4: public static string ReverseCase(string str)");
                Console.WriteLine("5: public static long Fact(int n)");
                Console.WriteLine("6: public static int NumberSyllables(string word)");
                Console.WriteLine("7: fenster");
                Console.WriteLine("0: EXIT PROGRAMM");
                Console.WriteLine(_line);
                try
                {
                    programmAuswahl = Convert.ToInt16(Console.ReadLine());
                }
                /* Wenn der Nutzer auf die Idee kommt keine Zahl einzugeben */
                catch (FormatException)
                {
                    Console.WriteLine("Illegales Zeichen! Gib eine Zahl ein!");
                    Console.WriteLine(_line);
                    programmAuswahl = -1;
                };

                switch (programmAuswahl)
                {
                    case 1:
                        int legs;
                        legs = Animals(2, 3, 5);
                        Console.WriteLine(legs);
                        Console.ReadLine();
                        break;

                    case 2:
                        decimal b, h;
                        Console.WriteLine("Gib b ein: ");
                        b = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Gib h ein: ");
                        Convert.ToInt16(Console.ReadLine());
                        h = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine(triangleArea(b, h));
                        break;

                    case 3:
                        //Space space1 = new Space(200, 200, 0);
                        //space1.initilizeSpace();         
                        break;
                    case 4:
                        string teststring = "HaloOOOH4";
                        Console.WriteLine(ReverseCase(teststring));
                        break;
                    case 5:
                        int n;
                        Console.WriteLine("Gib Zahl ein: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Fact(n));
                        break;
                    case 6:
                        string m;
                        Console.WriteLine("Gib ein Wo-Rt ein: ");
                        m = Console.ReadLine();
                        Console.WriteLine(NumberSyllables(m));
                        break;
                }
            } while (programmAuswahl != 0);
        }

        /* schreibt eine Linie in Konsole */
        public static void WriteLongLine()
        {
            Console.WriteLine(_line);

        }
        /* zählt Beine aller Tiere */
        public static int Animals(int chickens, int cows, int pigs)
        {
            return 2 * chickens + 4 * cows + 4 * pigs;
        }
        /* berechnet Fläche eines Dreiecks */
        public static decimal triangleArea(decimal b, decimal h)
        {
            return (b * h) / 2;
        }
        /* Ist teilbar durch 5? */
        public static bool divisibleByFive(int n)
        {
            int mod;
            mod = n % 5;
            return (n % 5) == 0;
        }
        /* gib Rest zurück */
        public static int Remainder(int x, int y)
        {
            return x % y;
        }
        /* Summe aus Array */
        public static int GetAbsSum(int[] arr)
        {
            int abssum = 0;
            for (int idx = 0; arr.Length > idx; idx++)
            {
                // wenn Math.Abs nicht genutzt werden darf, dann wenn arr[idx] < 0 dann * -1 nehmen
                abssum += Math.Abs(arr[idx]);
            }
            return abssum;
        }
        /* String wird umgekehrter Groß/Kleinschreibung zurückgegeben */
        public static string ReverseCase(string str)
        {
            string returnStr = ""; // is it empty?
            char[] checkStr = str.ToCharArray();

            foreach (char character in checkStr)
            {
                // wenn Zeichen is ascii 62 - 92 dann klein sonst groß     
                // if (char.IsDigit(character)) ist nicht nötig, weil er erkennt, dass es kein Buchstabe ist.
                if (char.IsDigit(character))
                    returnStr += character;
                else if (char.IsLower(character))
                    returnStr += char.ToUpper(character);
                else
                    returnStr += char.ToLower(character);
            }
            return returnStr;
        }
        /* Gibt Linie mit num Länge aus*/
        public static string Go(int num)
        {
            string line = "";
            string zeichen = "-";
            for (int i = 0; num > i; i++)
            {
                line += zeichen;
            }
            return line;

        }
        /* gibt kleinere stirng Zahl aus */
        public static string smallerNum(string n1, string n2)
        {
            // Ohne convert
            char[] number1 = n1.ToCharArray();
            char[] number2 = n2.ToCharArray();
            int laenge = 0;

            // check, ob ein String länger ist und nich tmit 0 beginnt
            // eigentlich muss noch geprüft werden, ob kein illegales Zeichen dabei ist
            if (n1.Length > n2.Length)
            {
                laenge = n1.Length;
                if (number1[0] > 0)
                    return n2;
            }
            else if (n1.Length < n2.Length)
            {
                laenge = n2.Length;
                if (number2[0] > 0)
                    return n1;
            }

            else
                laenge = n2.Length;

            for (int idx = 0; laenge > idx; idx++)
            {
                if (number1[idx] > number2[idx])
                    return n2;
                else if (number1[idx] < number2[idx])
                    return n1;
            }

            // wenn gleich, dann egal
            return n1;
        }
        /* !n */
        public static long Fact(int n)
        {
            if (n == 0)
                return 1;
            else if (n == -1)
                return 0;

            return n * Fact(n - 1);
        }
        /* gibt Anzahl der Silben aus */
        public static int NumberSyllables(string word)
        {
            int result = 1;
            char[] checkStr = word.ToCharArray();
            foreach (char character in checkStr)
            {
                if (character == '-')
                    result += 1;
            }
            return result;
        }
        public T v2d_generic<T>(T x, T y) where T : IConvertible
        {
            if (typeof(T) == typeof(int))
            {
                T mag()
                {
                    double a = Convert.ToDouble(x);
                    double b = Convert.ToDouble(y);
                    int c = Convert.ToInt32(Math.Sqrt(a * a + b * b));
                    return (T)Convert.ChangeType(c, typeof(T));
                }
            }
            return (T)x;
        }
    }
}

