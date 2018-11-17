using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input size of data");
            try
            {
                int n = Convert.ToInt16(Console.ReadLine());
                List<double> data = new List<double>();
                Console.WriteLine("Input data");
                for (int i = 0; i < n; i++)
                {
                    data.Add(Convert.ToDouble(Console.ReadLine()));
                }
                Operations oper = new Operations();
                Console.WriteLine(
                    "Choose operation:\n" +
                    "1 Maximum and minimum\n" +
                    "2 Mean\n" +
                    "3 Median\n" +
                    "4 Variance\n" +
                    "5 Quantile\n" +
                    "6 Exit"
                 );
                oper.Menu(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }           
            Console.ReadLine();

        }
    }
}
