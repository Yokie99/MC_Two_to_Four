

namespace MC_Challenge_Two_to_Four.Services.Sum;

    public class SumService : ISumService
    {
        public string Sum(int num1, int num2)
        {
            return $"The sum of {num1} and {num2} is {num1 + num2}";
        }
    }
