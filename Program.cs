//Name: Reagan Hau
//Instructor: Kevin Markley 1322L
//Section: 30
//Assignment: 1B
using System;

namespace ReaganHau_Lab1B
{
    class Tests
    {
        private string first;
        private string last;
        private int[] scores = new int[5];
        Tests() { }
        Tests(string Newfirst, string Newlast, int[] Newscores)
        {
            first = Newfirst;
            last = Newlast;
            scores = Newscores;
        }
        public int Average(int arr[])
        {
            int avg = (arr[0] + arr[1] + arr[2] + arr[3] + arr[4]) / 5;
            return avg;
        }
        public string Grade(int average)
        {
            switch ((average-average%10)/10)
            {
                case 0: return "F";
                    break;
                case 1: return "F";
                    break;
                case 2: return "F";
                    break;
                case 3: return "F";
                    break;
                case 4: return "F";
                    break;
                case 5: return "F";
                    break;
                case 6: return "D";
                    break;
                case 7: return "C";
                    break;
                case 8: return "B";
                    break;
                case 9: return "A";
                    break;
                case 10: return "A";
                    break;  
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name:");
            string f = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            string l = Console.ReadLine();
            Console.WriteLine("Enter Test Scores:");
            int[] testscores = new int[5];
            for(int i = 0; i < testscores.Length; i++)
            {
                testscores[i] = Int32.Parse(Console.ReadLine);
            }
            Tests t = new Tests(f, l, testscores);
        }
    }
}
