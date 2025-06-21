namespace Area_Calculation;

public class TriangleAreaCalculation
{
    public static void Run()
    {
        Console.WriteLine("Enter the base of the triangle: ");
        string baseInput = Console.ReadLine();

        Console.WriteLine("Enter the height of the triangle: ");
        string heightInput = Console.ReadLine();

        double baseLength;
        double height;

        bool isBaseValid = double.TryParse(baseInput, out baseLength);
        bool isHeightValid = double.TryParse(heightInput, out height);

        if (isBaseValid && isHeightValid && baseLength >= 0 && height >= 0)
        {
            double area = TriangleArea(baseLength, height);
            Console.WriteLine($"The area of the triangle is: {area:F2}");
        }
        else
        {
            Console.WriteLine("Please enter valid non-negative numbers for the base and height. ");
        }
    }

    public static double TriangleArea(double baseLength, double height)
    {
        return 0.5 * baseLength * height;
    }
}