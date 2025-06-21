namespace Area_Calculation;

class program
{
    public static double CalculateCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the radius of the circle: ");
        string input = Console.ReadLine();

        double radius;
        if (double.TryParse(input, out radius) && radius >= 0)
        {
            double area = CalculateCircleArea(radius);

            Console.WriteLine($"The area of the circle is: {area:F2}");
        }
        else
        {
            Console.WriteLine("Please enter a non-negative or valid number for the radius. ");
        }
        
        //Calling the triangle calculation Method
        TriangleAreaCalculation.Run();
    }

    
}