namespace Area_Calculation;

public class SquareAreaCalculation
{
    public static void Run()
    {
        Console.WriteLine("Enter the length of the side of the square: ");
        string sideInput = Console.ReadLine();

        double side;
        bool isSideValid = double.TryParse(sideInput, out side);

        if (isSideValid && side >= 0)
        {
            double area = CalculateArea(side);
            Console.WriteLine($"The area of the square is: {area:F2}");
        }
        else
        {
            Console.WriteLine("Please enter a valid non-negative number for the side.");
        }
    }

    public static double CalculateArea(double side)
    {
        return side * side;
    }
}