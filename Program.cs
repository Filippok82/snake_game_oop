
using Snake;
using Snake_oop;

class Program
{
    static void Main(string[] args)
    {

        Point p1 = new Point(1, 3, '*');
        p1.Draw();


        Point p2 = new Point(5, 7, '#');
        p2.Draw();

        HorizontalLine line = new HorizontalLine(5,10,8,'+');
        line.Drow();

        Console.ReadLine();
    }

}