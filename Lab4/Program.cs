namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
        // Step 1
        for (int i = 1; i <= 10; i++) 
        {
            Console.WriteLine(i);
        }
        // Step 2
        for (int i = 1; i <= 20; i++) 
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
        // Step 3
        int numb = 5;
        while (numb > 0) 
        {
            Console.WriteLine(numb);
            numb--;
        }

        // Step 4
        int bigNumber = 0;

        do
        {
            Console.WriteLine("Please enter a number greater than or equal to 100.");
            bigNumber = Convert.ToInt32(Console.ReadLine());
        }
        while (bigNumber < 100);

        // Step 5
        int numb2 = 10;
        while (numb2 <= 1000) 
        {
            Console.WriteLine(numb2);
            numb2 += 10;
        }

        // Step 6
        for (int i = 1; i <= 10; i++)
        {
            
            for (int stars = 1; stars <= i; stars++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
