namespace CalcWeightedMean.ConsoleApp
{
    internal class Program
    {
        private static void Main()
        {
            Console.Clear();

            Console.WriteLine("---------------------");
            Console.Write("Exam 1 grade > ");
            double exam1Grade =  Convert.ToDouble(Console.ReadLine());
            Console.Write("Exam 1 weight > ");
            double exam1Weight =  Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("---------------------");
            Console.Write("Exam 2 grade > ");
            double exam2Grade =  Convert.ToDouble(Console.ReadLine());
            Console.Write("Exam 2 weight > ");
            double exam2Weight =  Convert.ToDouble(Console.ReadLine());

            Student student = new Student 
            {
                GradeExam1 = exam1Grade,
                GradeExam2 = exam2Grade,
                WeightExam1 = exam1Weight,
                WeightExam2 = exam2Weight
            };

            Console.WriteLine("---------------------");
            Console.WriteLine
                ($"The weighted mean is {student.WeightedAverage:F2}");
        }
    }

    internal class Student
    {
        public double GradeExam1 { private get; init; }
        public double WeightExam1 { private get; init; }
        public double GradeExam2 { private get; init; }
        public double WeightExam2 { private get; init; }

        public double WeightedAverage =>
            (GradeExam1 * WeightExam1 +
                GradeExam2 * WeightExam2) /
                    (WeightExam1 + WeightExam2);
    }
}
