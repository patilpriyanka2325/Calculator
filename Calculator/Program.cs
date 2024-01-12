using static System.Console;

namespace Calculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            WriteLine("Enter first number");
            var number1 = Convert.ToDouble(ReadLine());

            WriteLine("Enter second number");
            var number2 = double.Parse(ReadLine());

            WriteLine("Enter operation");
            string operation = ReadLine().ToUpperInvariant();


            var calculator = new Calculation();
            try
            {
                var result = calculator.Calculate(number1, number2, operation);
                DisplayResult(result);
            }

            catch (/*CalculationException*/ Exception ex)
            {
                //Log.Error;
                WriteLine(ex);
            }
            finally
            {
                WriteLine("...Finally...");
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