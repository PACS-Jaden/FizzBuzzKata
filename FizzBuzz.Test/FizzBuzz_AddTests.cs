namespace FizzBuzz.Test
{
    public class FizzBuzz_AddTests
    {
        [Theory()]
        [InlineData(1,"1")]
        [InlineData(2,"2")]
        [InlineData(4,"4")]
        public void FizzBuzzReturnNumberWhenNotDivisibleAsString(int num, string expectedReturn)
        {

            Assert.Equal(expectedReturn, FizzBuzzClass.FizzBuzz.Add(num));
            
        }

        [Theory()]
        [InlineData(3,"Fizz")]
        [InlineData(6,"Fizz")]
        [InlineData(9,"Fizz")]
        public void FizzBuzzReturnFizzWhenDivisibleBy3(int num, string expectedReturn)
        {
            Assert.Equal(expectedReturn, FizzBuzzClass.FizzBuzz.Add(num));
        }

        [Theory()]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        [InlineData(1000, "Buzz")]
        public void FizzBuzzReturnBuzzWhenDivisibleBy5(int num, string expectedReturn)
        {
            Assert.Equal(expectedReturn, FizzBuzzClass.FizzBuzz.Add(num));
        }

        [Theory()]
        [InlineData(15, "FizzBuzz")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(120, "FizzBuzz")]
        public void FizzBuzzReturnFizzBuzzWhenDivisibleBy5And3(int num, string expectedReturn)
        {
            Assert.Equal(expectedReturn, FizzBuzzClass.FizzBuzz.Add(num));
        }
    }
}