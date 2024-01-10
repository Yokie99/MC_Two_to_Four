

namespace MC_Challenge_Two_to_Four.Services.GreaterOrLessThan;

public class GreaterOrLessThanService : IGreaterOrLessThanService
{
    public List<string> temp = new();
    public List<string> GreaterOrLessThan(int num1, int num2)
    {
        
        if (num1 > num2)
        {
            temp.Add($"Your first number, {num1}, is greater than your second number, {num2}.");
            temp.Add($"The second number, {num2}, is less than the first number, {num1}.");
        }
        else if (num2 > num1)
        {
            temp.Add($"The first number, {num1}, is less than the second number, {num2}.");
            temp.Add($"The second number, {num2}, is greater the first number, {num1}.");
        }
        else
        {
            temp.Add($"The first number, {num1}, is equal to the second number, {num2}.");
            temp.Add($"The second number, {num2}, is equal to the first number, {num1}.");
        }

      
        return temp;
    }
}
