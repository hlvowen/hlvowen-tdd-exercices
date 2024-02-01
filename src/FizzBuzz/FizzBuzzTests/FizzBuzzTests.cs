
namespace FizzBuzzTests;

public class FizzBuzzTests
{
    [Fact]
    public void Should_return_same_number_when_it_is_not_multiple_of_three_or_five()
    {
        FizzBuzz fizzBuzz = new FizzBuzz();
        int number = 1;
        string actual = fizzBuzz.Print(number);
        Assert.Equal("1", actual);
    }

    [Fact]
    public void Should_return_fizz_when_number_is_multiple_of_three()
    {
        FizzBuzz fizzBuzz = new FizzBuzz();
        int number = 3;
        string actual = fizzBuzz.Print(number);
        Assert.Equal("Fizz", actual);
    }
    
    [Fact]
    public void Should_return_buzz_when_number_is_multiple_of_five()
    {
        FizzBuzz fizzBuzz = new FizzBuzz();
        int number = 5;
        string actual = fizzBuzz.Print(number);
        Assert.Equal("Buzz", actual);
    }
    
    [Fact]
    public void Should_return_fizzbuzz_when_number_is_multiple_of_three_and_five()
    {
        FizzBuzz fizzBuzz = new FizzBuzz();
        int number = 15;
        string actual = fizzBuzz.Print(number);
        Assert.Equal("FizzBuzz", actual);
    }
}