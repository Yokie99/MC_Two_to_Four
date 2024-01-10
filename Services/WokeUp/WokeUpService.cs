

namespace MC_Challenge_Two_to_Four.Services.WokeUp;

    public class WokeUpService : IWokeUpService
    {
        public string WokeUp(string name, string time)
        {
            return $"Hi {name}! Looks like you woke up at {time} today. Great Job!";
        }
    }
