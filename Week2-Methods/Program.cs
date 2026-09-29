using Week2_Methods;

Main();

static void Main()
{
    try
    {
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();
        Hello.SayHello(name);
        double length = 0;
        double width = 0;
        Console.WriteLine("PLease enter rectangle length");
        string lengthInput = Console.ReadLine();
        while (!double.TryParse(lengthInput, out length))
        {
            Console.WriteLine("Please enter a valid number for length.");
            lengthInput = Console.ReadLine();
        }
        Console.WriteLine("Please enter rectangle width");
        string widthInput = Console.ReadLine();
        while (!double.TryParse(widthInput, out width))
        {
            Console.WriteLine("Please enter a valid number for width.");
            widthInput = Console.ReadLine();
        }

        // Calling the method and storing the result
        double area = Hello.CalculateArea(length, width);

        // Output the result
        Console.WriteLine($"The area of the rectangle is: {area}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}