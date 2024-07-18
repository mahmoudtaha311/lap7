using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap7
{
    public class BMICalculator
    {
        public List<Result> Results = new List<Result>();

        public Result Calculate()
        {
            Console.WriteLine("Enter weight");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height");
            double height = double.Parse(Console.ReadLine());

            double bmi = weight / (height * height);
            string category = "";

            if (bmi < 18.5)
                category = "Underweight";
            else if (bmi >= 18.5 && bmi <= 24.9)
                category = "Normal weight";
            else if (bmi >= 25 && bmi <= 29.9)
                category = "Overweight";
            else if (bmi >= 30)
                category = "Obesity";

            Result result = new Result
            {
                Weight = weight,
                Height = height,
                BMI = bmi,
                Category = category
            };

            Results.Add(result);
            Console.WriteLine($"PMI = {bmi} ");
            return result;
        }
        public void VeiwPrevice()
        {
            foreach (Result result in Results)
            {
                Console.WriteLine(result);
            }
        }


        public class Result
        {
            public double Weight { get; set; }
            public double Height { get; set; }
            public double BMI { get; set; }
            public string Category { get; set; }


            public override string ToString()
            {
                return $" PMI= {BMI}";
            }
        }
    }
}