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
        private double average;
        private string grade;
        Tests() { }
        Tests(string Newfirst, string Newlast, int[] Newscores, double Newaverage, string Newgrade)
        {
            first = Newfirst;
            last = Newlast;
            scores = Newscores;
            average = Newaverage;
            grade = Newgrade;
        }
        static void Print(string first, string last, int[] scores, double average, string grade)
        {
            Console.WriteLine(first + "   " + last + "   " + (double)scores[0] + "   " + (double)scores[1] + "   " + (double)scores[2] + "   " + (double)scores[3] + "   " + (double)scores[4] + "   " + average + "   " + grade);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Names:");
            int[] firsts = new int[10];
            for (int j = 0; j < 10; j++)
            {
                firsts[j] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter Last Names:");
            int[] lasts = new int[10];
            for (int k = 0; k < 10; k++)
            {
                lasts[k] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter Test Scores:");
            int[,]testscores = new int[10,5];
            for(int i = 0; i < 10; i++)
            {
                for(int c = 0; c < 5; c++)
                {
                    testscores[i,c] = Int32.Parse(Console.ReadLine());
                }
            }
            int[] average = new int[10];
            for (int w = 0; w < 10; w++) {
                average[w] = (testscores[w,0] + testscores[w,1] + testscores[w,2] + testscores[w,3] + testscores[w,4]) / 5;
            }
            int[] grade = new int[10];
            for (int p = 0; p < 10; p++) {
                switch ((average[p] - average[p] % 10) / 10)
                {
                    case 0: grade[p] = Int32.Parse("F");
                        break;
                    case 1: grade[p] = Int32.Parse("F");
                        break;
                    case 2: grade[p] = Int32.Parse("F");
                        break;
                    case 3: grade[p] = Int32.Parse("F");
                        break;
                    case 4: grade[p] = Int32.Parse("F");
                        break;
                    case 5: grade[p] = Int32.Parse("F");
                        break;
                    case 6: grade[p] = Int32.Parse("D");
                        break;
                    case 7: grade[p] = Int32.Parse("C");
                        break;
                    case 8: grade[p] = Int32.Parse("B");
                        break;
                    case 9: grade[p] = Int32.Parse("A");
                        break;
                    case 10: grade[p] = Int32.Parse("A");
                        break;
                    default: grade[p] = Int32.Parse(" "); Console.WriteLine("Invalid input. Try again.");
                        break; } }
                    Console.WriteLine("First Name   Last Name   Test1   Test2   Test3   Test4   Test5   Average   Grade");
                    for (int h = 0; h < 10; h++) {
                Console.WriteLine(firsts[h] + "   " + lasts[h] + "   " + testscores[h,0] + "   " + testscores[h,1] + "   " + testscores[h,2] + "   " + testscores[h,3] + "   " + testscores[h,4] + "   " + average[h] + "   " + grade[h]);
            }
        }
    }
}
