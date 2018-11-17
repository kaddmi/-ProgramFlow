using System;
using System.Collections.Generic;
using MathNet.Numerics.Statistics;

namespace Statistics
{
    class Operations
    {
        public void Menu(List<double> data)
        {           
            int choose = 0;
            while (choose!=6)
            {
                choose = Convert.ToInt16(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        {
                            Console.WriteLine(data.Maximum() + "; " + data.Minimum());
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(data.Mean());
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(data.Median());
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine(data.Variance());
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Input tau [0,0 - 1,0]");
                            Console.WriteLine(data.Quantile(Convert.ToDouble(Console.ReadLine())));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Press any key to exit");
                            return;
                        }
                }
            }
        }
    }
}
