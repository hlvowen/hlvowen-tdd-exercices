namespace FizzBuzzTests;

public class FizzBuzz
{
    public string Print(int number)
    {
        const int FizzMultiplier = 3;
        const int BuzzMultiplier = 5;
        const string FIZZ = "Fizz";
        const string BUZZ = "Buzz";

        if (IsMultipleOf(number, FizzMultiplier) && IsMultipleOf(number, BuzzMultiplier))
        {
            return $"{FIZZ}{BUZZ}";
        }
        
        if (IsMultipleOf(number, BuzzMultiplier))
        {
            return BUZZ;
        }
        
        if (IsMultipleOf(number, FizzMultiplier))
        {
            return FIZZ;
        }
        
        return number.ToString();
    }

    private bool IsMultipleOf(int number, int divider)
    {
        return number % divider == 0;
    }
}