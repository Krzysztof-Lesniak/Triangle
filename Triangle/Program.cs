namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinate x of dot A:");
            double ax = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot A:");
            double ay = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate x of dot B:");
            double bx = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot B:");
            double by = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate x of dot C:");
            double cx = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot C:");
            double cy = double.Parse(Console.ReadLine());
            Console.WriteLine();

            LengthOfSides(ax, ay, bx, by, cx, cy);
        }
        private static void LengthOfSides(double ax, double ay, double bx, double by, double cx, double cy)
        {
            double ab = Math.Round(Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2)), 2);
            double bc = Math.Round(Math.Sqrt(Math.Pow(bx - cx, 2) + Math.Pow(by - cy, 2)), 2);
            double ca = Math.Round(Math.Sqrt(Math.Pow(cx - ax, 2) + Math.Pow(cy - ay, 2)), 2);
            double perimeter = Math.Round(ab + bc + ca, 3);

            Console.WriteLine($"Length of AB is: {ab}");
            Console.WriteLine($"Length of BC is: {bc}");
            Console.WriteLine($"Length of CA is: {ca}");
            Console.WriteLine();

            IsEquilateralTriangle(ab, bc, ca);
            IsIsoscelesTriangle(ab, bc, ca);
            IsRightTriangle(ab, bc, ca);
            Console.WriteLine();
            Console.WriteLine($"the perimeter of the triangle is {perimeter}");
            Console.WriteLine();
            Console.WriteLine("Parity numbers in range from 0 to triangle perimeter:");
            EvenValuels(perimeter);
        }
        private static void IsIsoscelesTriangle(double ab, double bc, double ca)
        {
            if (ab == bc || bc == ca || ca == ab)
            {
                Console.WriteLine("Triangle is isosceles");
            }
            else Console.WriteLine("Triangle is NOT isosceles");
        }
        private static void IsEquilateralTriangle(double ab, double bc, double ca)
        {
            if (ab == bc && bc == ca)
            {
                Console.WriteLine("Triangle is equilateral");
            }
            else Console.WriteLine("Triangle is NOT equilateral");
        }
        private static void EvenValuels(double perimeter)
        {
            for (int i = 0; i < perimeter; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        private static void IsRightTriangle(double ab, double bc, double ca)
        {
            bool angleA = Math.Round(Math.Pow(ab, 2) + Math.Pow(bc, 2), 1) == Math.Round(Math.Pow(ca, 2), 1);
            bool angleB = Math.Round(Math.Pow(bc, 2) + Math.Pow(ca, 2), 1) == Math.Round(Math.Pow(ab, 2), 1);
            bool angleC = Math.Round(Math.Pow(ca, 2) + Math.Pow(ab, 2), 1) == Math.Round(Math.Pow(bc, 2), 1);

            if (angleA || angleB || angleC)
            {
                Console.WriteLine("Triangle is: right");
            }
            else Console.WriteLine("Triangle is: NOT right");
        }
    }
}