namespace HarmonicMeanOfGrades.ConsoleApp
{
    internal class Program
    {
        private static void Main()
        {
            Console.Clear();

            List<double> grades = new();
            do
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Enter 'S' to stop adding");
                Console.WriteLine("-------------------------");
                Console.Write("Enter the grade(s) > ");
                string grade = Console.ReadLine(); 

                if (grade.ToUpper() == "S") break;

                grades.Add(Convert.ToDouble(grade));

            } while (true);

            Student student = new Student
            {
                Grades = grades
            };

            Console.WriteLine("-------------------------");
            Console.WriteLine($"The harmonic grade is {student.HarmonicGrade:F2}");
        }
    }

    internal class Student
    {
        // H = N/(1/X) + (1/Y) + (1/Z)
        public List<double> Grades { private get; init; }

        public double HarmonicGrade =>
            CalcHarmonicMean();

        private double CalcHarmonicMean()
        {
            double gradesSum = 0;
            foreach (double grade in Grades)
            {
                gradesSum += 1 / grade;
            }

            return Grades.Count / gradesSum;
        }
    }
}
