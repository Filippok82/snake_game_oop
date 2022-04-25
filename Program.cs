
using Snake_oop;
using System;
using System.Collections.Generic;
using System.Threading;



namespace Snake_oop;

    class Program
    {
    static void Main(string[] args)
    {
        Console.SetWindowSize(1, 1);
        Console.SetWindowSize(80, 35);
        Console.SetBufferSize(80, 35);

        

        Point p = new Point(4, 3, '+');
        Snake snake = new Snake(p, 4, Direction.RIGHT);
        snake.Drow();
        snake.Move();
        Thread.Sleep(300);
        snake.Move();
        Thread.Sleep(300);
        snake.Move();
        Thread.Sleep(300);
        snake.Move();
        Thread.Sleep(300);
        snake.Move();
        Thread.Sleep(300);
        snake.Move();
        Thread.Sleep(300);
        snake.Move();
        Thread.Sleep(300);
        snake.Move();
        Thread.Sleep(300);
        snake.Move();
        Thread.Sleep(300);


        HorizontalLine upLine = new HorizontalLine(0, 78, 0, '*');
        upLine.Drow();
        HorizontalLine downLine = new HorizontalLine(0, 78, 24, '*');
        downLine.Drow();
        VerticalLine leftLine = new VerticalLine(0,24, 0, '*');
        leftLine.Drow();
        VerticalLine rightLine = new VerticalLine(0, 24, 78, '*');
        rightLine.Drow();
        
       

    }
}
    
