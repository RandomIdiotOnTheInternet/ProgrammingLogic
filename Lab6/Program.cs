using System;

class Car
{
  public string model;
  public string color;
  public int year;

  // Example method to display car details. You can use this as an example for the other methods.
  public void Display()
  {
    Console.WriteLine("Car Details:");
    Console.WriteLine("Model: " + model);
    Console.WriteLine("Color: " + color);
    Console.WriteLine("Year: " + year);
  }

  public void Start()
  {
    Console.WriteLine("The car is starting.");
  }

  public void Drive(int miles)
  {
    Console.WriteLine("The car drove " + Convert.ToString(miles) + " miles.");
  }

  public string GetDescription()
  {
    return year + " " + color + " " + model;
  }

  public void Repaint(string newColor)
  {
    color = newColor;
    Console.WriteLine("The car has been repainted to " + color + ".");
  }

  public int CurrentAge()
  {
    return 2025 - year;
  }
}

class Program
{
  static void Main()
  {
    // Creating a Car object and assigning values to its properties
    Car myCar = new Car();
    myCar.model = "Civic";
    myCar.color = "Black";
    myCar.year = 2020;

    myCar.Display(); // Calling the Display method

    // Step 1

    myCar.Start();

    // Step 2

    myCar.Drive(50);

    // Step 3

    string description = myCar.GetDescription();
    Console.WriteLine(description);

    // Step 4

    myCar.Repaint("Red");
    Console.WriteLine(myCar.color);

    // Step 5
    // I noticed this was in the Rubric, even though it appears to be absent from the main lab page as of 4/22/2025.
    // Even though it could just be a mistake in the Rubric, I decided to do it anyway to be on the safe side :)

    Console.WriteLine("My car is " + Convert.ToString(myCar.CurrentAge()) + " years old.");
  }
}
