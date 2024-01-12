using static System.Console;

namespace Calculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                string userChoice = string.Empty;
                do
                {
                    WriteLine("Enter first number");
                    double number1 = Convert.ToDouble(ReadLine());

                    WriteLine("Enter second number");
                    var number2 = Convert.ToDouble(ReadLine());

                    WriteLine("Enter operation");
                    string operation = ReadLine();


                    var calculator = new Calculation();
                    var result = calculator.Calculate(number1, number2, operation);
                    DisplayResult(result);


                    do
                    {
                        Console.WriteLine("do you want to continue... Yes/ No?");
                        userChoice = Console.ReadLine().ToUpper();

                        if (userChoice != "YES" && userChoice != "NO")
                        {
                            Console.WriteLine("Your choice {0} is invalid...! Please try again", userChoice);
                        }
                    } while (userChoice != "YES" && userChoice != "NO");
                } while (userChoice == "YES");

            }

            catch (/*CalculationException*/ Exception ex)
            {
                //Log.Error;
                WriteLine(ex);
            }

            WriteLine("\nPress enter to exit.");
            ReadLine();
        }

        private static void DisplayResult(double result)
        {
            WriteLine($"Result is: {result}");
        }
    }
}