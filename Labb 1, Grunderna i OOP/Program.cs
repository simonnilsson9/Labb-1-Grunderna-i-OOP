namespace Labb_1__Grunderna_i_OOP //Simon Nilsson SUT23
{
    internal class Circle
    {
        int _Radius;
        float pi = 3.141f;
        public Circle(int radius)
        {
            _Radius = radius;
        }
        public double getArea()
        {
            return (_Radius * _Radius * pi);
        }        
        public double getCircum()
        {
            return (2 * pi * _Radius); 
        }
        public double getVolume()
        {
            return ((4 * pi * _Radius * _Radius * _Radius) / 3); //Mathematic to calculate the volume och the circle. 
        }        
    }
    internal class Triangle
    {
        public double buttom { get; set; }
        public double height { get; set; }
        public double getTriangleArea()
        {
            return ((buttom * height) / 2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            Console.WriteLine($"Cirkel nr 1:\nArea: {circle1.getArea()}\nOmkrets: {circle1.getCircum()}\nVolym: {circle1.getVolume()}\n");
            Console.WriteLine($"Cirkel nr 2:\nArea: {circle2.getArea()}\nOmkrets: {circle2.getCircum()}\nVolym: {circle2.getVolume()}\n");

            Triangle triangle = new Triangle();
            Console.Write("Skriv in basen på din triangel: ");
            triangle.buttom = Convert.ToDouble(Console.ReadLine());
            Console.Write("Skriv in höjden på din triangel: ");
            triangle.height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"\nArean på din triangel är: {triangle.getTriangleArea()}");
            
        }
    }
}