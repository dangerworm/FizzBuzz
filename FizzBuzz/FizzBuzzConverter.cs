namespace FizzBuzz
{
    public class FizzBuzzConverter
    {
        public string GetOutput(int number)
        {
            /*
            if (number % 3 != 0 && number % 5 != 0)
            {
                return number.ToString();
            }
            else if (number % 5 == 0 && number % 3 == 0)
            {
                return "fizzbuzz";
            }
            else if (number % 3 == 0)
            {
                return "fizz";
            }
            else
            {
                return "buzz";
            }
            */

            return number % 3 != 0 && number % 5 != 0 
                ? number.ToString() 
                : $"{CheckFizz(number)}{CheckBuzz(number)}";
        }

        private string CheckFizz(int number)
        {
            return number % 3 == 0 
                ? "fizz" 
                : string.Empty;
        }

        private string CheckBuzz(int number)
        {
            return number % 5 == 0
                ? "buzz"
                : string.Empty;
        }
    }
}
