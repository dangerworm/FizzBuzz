using FizzBuzz;

namespace FizzBuzzTests
{
    public class FizzBuzzTests
    {
        private readonly FizzBuzzConverter _fizzBuzz;

        public FizzBuzzTests() 
        {
            _fizzBuzz = new FizzBuzzConverter();
        }  

        [Fact]
        public void Number1Returns1AsString()
        {
            var number = 1;

            var result = _fizzBuzz.GetOutput(number);

            Assert.Equal("1", result);
        }
        
        [Fact]
        public void Number2Returns2AsString()
        {
            var number = 2;

            var result = _fizzBuzz.GetOutput(number);

            Assert.Equal("2", result);
        }

        [Fact]
        public void Number3ReturnsFizzAsString()
        {
            var number = 3;

            var result = _fizzBuzz.GetOutput(number);

            Assert.Equal("fizz", result);
        }

        [Fact]
        public void Number5ReturnsBuzzAsString()
        {
            var number = 5;

            var result = _fizzBuzz.GetOutput(number);

            Assert.Equal("buzz", result);
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        [InlineData(7, "7")]
        [InlineData(8, "8")]
        public void NumberNotDivisibleBy3Or5ReturnsInputAsString(int input, string expectedOutput)
        {
            var number = input;

            var result = _fizzBuzz.GetOutput(number);

            Assert.Equal(expectedOutput, result);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        [InlineData(60)]
        [InlineData(75)]
        public void NumberIsMultipleOf3And5ReturnsFizzBuzz(int input)
        {
            var number = input;

            var result = _fizzBuzz.GetOutput(number);

            Assert.Equal("fizzbuzz", result);
        }
    }
}