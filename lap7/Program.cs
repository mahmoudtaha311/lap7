namespace lap7
{
    internal class Program
    {


        
        
        static void Main(string[] args)
        {


            //Calculator<int> OP = new Calculator<int>();

            //Console.WriteLine(OP.Add(2,5));





           


            //--------------------------------------------------

            
            while (true)
            {


                Console.WriteLine("choose from the options");

                Console.WriteLine("Calculate BMI  => 1");

                Console.WriteLine("Veiw previous  BMI  => 2");

                Console.WriteLine(" Exit  => 3");

                int option = int.Parse(Console.ReadLine());

                BMICalculator bMICalculator = new BMICalculator();

               
                switch (option)
                {

                    case 1:
                        bMICalculator.Calculate();
                       
                        break;
                    case 2:
                        bMICalculator.VeiwPrevice();


                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again");
                        break;


                }

            }

        }



        }
    }
