namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
        // Step 1

        string[] seasons = {"Spring", "Summer", "Fall", "Winter"};

        int index = 0;
        foreach (string value in seasons)
        {
            Console.WriteLine("Season: " + seasons[index]);
            index++;
        }

        // Step 2

        string[] daysOfTheWeek = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

        Console.WriteLine("What day of the week is it? (Please enter a number 1-7 where 1 is Monday).");
        int input = Convert.ToInt32(Console.ReadLine());

        if (input >= 1 && input <= daysOfTheWeek.Length)
        {
            Console.WriteLine(daysOfTheWeek[input - 1]);
        } else
        {
            Console.WriteLine("Invalid input! :(");
        }

        // Step 3

        string[] books = {"The Lord of The Rings", "Animal Farm", "A Sweet-Scented Journey"};
        string[] authors = {"J.R.R. Tolkien", "George Orwell", "Father Dionysios Tampakis"};

        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine("Book " + Convert.ToString(i + 1) + ": " + books[i] + " by " + authors[i]);
        }

        // Step 4

        int[] temperatures = {65, 72, 78, 70, 68};

        Array.Sort(temperatures);
        Console.Write("Sorted Temperatures:");
        for (int i = 0; i < temperatures.Length; i++)
        {
            Console.Write(" " + temperatures[i]);
        }
        Console.WriteLine();

        Console.WriteLine("Highest Temperature: " + temperatures[temperatures.Length - 1]);
        Console.WriteLine("Lowest Temperature: " + temperatures[0]);

        // Step 5

        int[] countdown = {5, 4, 3, 2, 1};
        Array.Reverse(countdown);
        Console.Write("Countdown:");
        for (int i = 0; i < countdown.Length; i++)
        {
            Console.Write(" " + countdown[i]);
        }
        Console.WriteLine();
    }   
}
