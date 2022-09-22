namespace FiguresLibrary
{
    public class Figure
    {
        public double Area { get; set; }
        public double Perimeter { get; set; }
        public virtual double GetArea()
        {
            return Area;
        }
        public virtual double GetPerimeter()
        {
            return Perimeter;
        }

        public void DisplayInfo()
        {
            if (GetArea() != 0)
            {
                Console.WriteLine($"Площадь: {Math.Round(GetArea(), 6)}");
                Console.WriteLine($"Периметр: {Math.Round(GetPerimeter(), 6)}");
            }else
            Console.WriteLine("Данной фигуры не существует");
        }
    }
}
