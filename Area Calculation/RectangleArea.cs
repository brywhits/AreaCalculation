namespace Area_Calculation;

public class RectangleArea
{
    public static void Run()
    {
        Console.WriteLine("Enter the width of the rectangle: ");
        string widthInput = Console.ReadLine();
        
        Console.WriteLine("Enter the height of the rectangle: ");
        string heightInput = Console.ReadLine();

        double width;
        double height;
        
        bool isWidthValid = double.TryParse(widthInput, out width);
        bool isHeightValid = double.TryParse(heightInput, out height);

        if (isWidthValid && isHeightValid && width > 0 && height >= 0)
        {
            double area = RectangleCalcArea(width, height);
            Console.WriteLine($"The area of the rectangle is: {area:F2}");
        }
        else
        {
            {
                Console.WriteLine("Please enter valid, non-negative number for the width and height.");
            }
        }
    }
    public static double RectangleCalcArea(double width, double height)
    {
        return width * height;
    }
}