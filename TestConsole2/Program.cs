using System.Linq.Expressions;

namespace TestConsole2
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            string season = Console.ReadLine().ToUpper();
            switch (season)
            {
                case "HR":
                    Console.WriteLine("İnsan Resursları şöbəsi");
                    break;
                case "IT":
                    Console.WriteLine("İnformasiya texnologiyaları şöbəsi");
                    break;
                case "FİNANCE":
                    Console.WriteLine("Finans şöbəsi yazsın");
                    break;
                default:
                    Console.WriteLine("Belə bir şöbə yoxdur");
                    break;
            }
            #endregion

            #region Task2

            if (int.TryParse(Console.ReadLine(), out int input))
            {
                Console.WriteLine($"Your Salary {CalculateSalary(input)}");
            }



            #endregion

            #region Task3


            int hour = DateTime.Now.Hour;
            if (hour > 17)
            {
                Console.WriteLine($"Good evening, Today is {DateTime.Now.DayOfWeek}");
            }
            else if (hour < 12)
            {
                Console.WriteLine($"Good morning, Today is {DateTime.Now.DayOfWeek}");
            }
            else
            {
                Console.WriteLine($"Good afternoon, Today is {DateTime.Now.DayOfWeek}");
            }
            #endregion

            #region Task4
            int[] values = new int[] {2,4,6};
            Console.WriteLine(values.Sum()/3 > 20 ? "aktive":"deaktive");
            #endregion

        }

        static int CalculateSalary(int seniority)
        {
            if (seniority >= 0 && seniority <= 2)
            {
                return 2000;
            }
            else if (seniority >= 3 && seniority <= 5)
            {
                return 5000;
            }
            else if (seniority >= 6 && seniority <= 10)
            {
                return 7000;
            }
            else
            {
                return 10000;
            }
        }

        
    }
}