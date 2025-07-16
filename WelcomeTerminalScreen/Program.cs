namespace WelcomeTerminalScreen;

class Program
{
    static void Main(string[] args)
    {
        // Variables
        var day = Convert.ToString(DateTime.Today.DayOfWeek);
        var hour = DateTime.Now.Hour;
        Random rand = new Random();
        int randLang = rand.Next(1, 4);
        String user = Environment.UserName;

        Greeting(randLang, user, hour);
        Console.WriteLine($"It's {day}.");
    }
    static void Greeting(int randLang, String user, int hour)
    {
        switch (randLang)
        {
            case 1:
                if (hour <= 18)
                {
                    Console.WriteLine($"Dzień Dobry, {user}!");
                }
                else
                {
                    Console.WriteLine($"Dobry Wieczór, {user}!");
                }
                break;
            
            case 2:
                if (hour <= 12)
                {
                    Console.WriteLine($"Good Morning, {user}!");
                }
                else if (hour <= 18)
                {
                    Console.WriteLine($"Good Afternoon, {user}!");
                }
                else
                {
                    Console.WriteLine($"Good Evening, {user}!");
                }
                break;
            case 3:
                if (hour <= 18)
                {
                    Console.WriteLine($"Bonjour, {user}!");
                }
                else
                {
                    Console.WriteLine($"Bonsior, {user}!");
                }
                break;
        }
    }
}