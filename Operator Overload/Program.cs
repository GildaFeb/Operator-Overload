using System;

namespace Operator_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" --------------------------");
            Console.WriteLine("       Pedro's Grade");
            Console.WriteLine("  Math: 98\n  English: 95\n  Filipino: 93 \n  Science: 98");
            Console.WriteLine("  -----------------------");
            Grade math = new Grade(1, 98);
            Grade english = new Grade(1, 95);
            Grade filipino = new Grade(1, 93);
            Grade science = new Grade(1, 98);
            Grade all = math + english + filipino + science;
            double average = all.sum / all.count;
            Console.WriteLine("\n  Total No. of All Subjects: " + all.count);
            Console.WriteLine("  Sum of all grades: " + all.sum);
            Console.WriteLine("  Average grade: " + "{0:0.00}", average);
            Console.ReadKey();
        }
    }
    class Grade
    {
        public int count
        {
            get;
            set;
        }

        public int sum
        {
            get;
            set;
        }
        public Grade(int a, int w)
        {
            count = a;
            sum = w;
        }
        public static Grade operator +(Grade a, Grade b)
        {
            int c = a.count + b.count;
            int s = a.sum + b.sum;
            Grade combine = new Grade(c, s);
            return combine;
        }


    }
}
