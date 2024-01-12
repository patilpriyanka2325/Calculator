namespace Calculator
{
    internal class Calculation
    {
        public double Calculate(double number1, double number2, string operation)
        {

            double answer;

            switch (operation)
            {
                case "+":
                    answer = Add(number1, number2);
                    break;

                case "-":
                    answer = Minus(number1, number2);
                    break;

                case "*":
                    answer = Multiply(number1, number2);
                    break;

                case "/":
                    answer = Divide(number1, number2);
                    break;

                default:
                    Console.WriteLine("Your choice {0} is invalid...!, Please try again", operation);
                    answer = 0;
                    break;
            }
            return answer;
        }

        private double Add(double number, double anotherNumber)
        {
            try
            {
                var result = number + anotherNumber;
                return result;
            }
            catch (ArithmeticException ex)
            {
                throw new /*CalculationException*/ Exception("An error occured during division", ex);
            }

        }

        private double Minus(double number, double anotherNumber)
        {
            try
            {
                var result = number - anotherNumber;
                return result;
            }
            catch (ArithmeticException ex)
            {
                throw new /*CalculationException*/ Exception("An error occured during division", ex);
            }

        }

        private double Multiply(double number, double anotherNumber)
        {
            try
            {
                var result = number * anotherNumber;
                return result;
            }
            catch (ArithmeticException ex)
            {
                throw new /*CalculationException*/ Exception("An error occured during division", ex);
            }

        }

        private double Divide(double number, double divisor)
        {
            try
            {
                var result = number / divisor;
                return result;
            }
            catch (ArithmeticException ex)
            {
                throw new /*CalculationException*/ Exception("An error occured during division", ex);
            }

        }

    }
}
