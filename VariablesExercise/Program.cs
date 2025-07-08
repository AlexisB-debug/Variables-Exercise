namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string kittenName = "Sweetums";
            int kittenAgeInWeeks = 12;
            char kittenSex = 'F';
            bool kittenIsHealthy = true;
            double kittenWeightInPounds = 3.0d;
            decimal kittenCostInUSD = 700.00m;
            Console.WriteLine($"Kris Kringle gifted me a ragdoll kitten whom the veterinarian named {kittenName}.");
            Console.WriteLine($"The birth certificate reads {kittenSex} so the state knows she's a girl!");
            Console.WriteLine($"She was {kittenAgeInWeeks} weeks young when I received her.");
            Console.WriteLine($"It is {kittenIsHealthy} that she is healthy, weighing {kittenWeightInPounds} pounds.");
            Console.WriteLine($"Father Christmas spent ${kittenCostInUSD}, but her purr is priceless!");
        }
    }
}
