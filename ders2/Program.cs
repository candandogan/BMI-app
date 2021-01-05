using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double height;
            double weight;
            double bmi;

            try
            {
                Console.WriteLine("Please enter your height in meters = ");
                height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter your weight in kilograms = ");
                weight = double.Parse(Console.ReadLine());

                bmi = weight / (height * height);
                Console.WriteLine("Your body mass index (BMI) = " + bmi);
                if (bmi < 16)
                {
                    Console.WriteLine("Severe Thinness");
                }
                else if (bmi >= 16 && bmi <= 17)
                {
                    Console.WriteLine("Moderate Thinness");
                }
                else if (bmi > 17 && bmi <= 18.25)
                {
                    Console.WriteLine("Mild Thinness");
                }
                else if (bmi > 18.25 && bmi <= 25)
                {
                    Console.WriteLine("Normal");
                }
                else if (bmi > 25 && bmi <= 30)
                {
                    Console.WriteLine("Overweight");
                }
                else if (bmi > 30 && bmi <= 35)
                {
                    Console.WriteLine("Obese Class I");
                }
                else if (bmi > 35 && bmi <= 40)
                {
                    Console.WriteLine("Obese Class II");
                }
                else if (bmi > 40)
                {
                    Console.WriteLine("Obese Class III");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("An error occured = " + error);
            }
            Console.ReadLine();
        }
    }
}
