namespace SellerTotalSalary.ConsoleApp
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Base salary > ");
            double baseSalary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Total sales > ");
            int totalSales = Convert.ToInt32(Console.ReadLine());
            Console.Write("Comission percentage > ");
            double comissionPercentage = Convert.ToDouble(Console.ReadLine());

            Seller seller = new Seller 
            {
                BaseSalary = baseSalary,
                TotalSales = totalSales,
                ComissionPercentage = comissionPercentage
            };

            Console.Write
                ($"Salary with comission is {seller.SalaryWithComission}");
        }
    }
    
    internal class Seller 
    {
        public double BaseSalary { private get; init; }
        public int TotalSales { private get; init; }
        public double ComissionPercentage { private get; init; }
        
        public double SalaryWithComission =>
            BaseSalary + (TotalSales * ComissionPercentage / 100);
    }
}
