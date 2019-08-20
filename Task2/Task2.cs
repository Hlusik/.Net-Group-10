using System;

namespace Task2
{
    public interface IDrawable
    {
        void Draw();
    }
    public class Figure : IDrawable
    {
        public int X { get; }
        public int Y { get; }
        public Figure(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public virtual void Draw()
        {
            Console.WriteLine("Figure draw method\n");
        }
    }

    public class Square : Figure, IDrawable
    {
        public Square(int x, int y) : base(x, y) { }
        public override void Draw()
        {
            Console.WriteLine("Square draw method\n");
        }
    }

    public class Rectangle : Figure, IDrawable
    {
        public Rectangle(int x, int y) : base(x, y) { }
        public override void Draw()
        {
            Console.WriteLine("Rectangle draw method\n");
        }
    }
    
    public class Task2
    {
        public void DrawAll(params IDrawable[] array)
        {
            foreach (IDrawable i in array)
            {
                i.Draw();
            }
        }
        public void Execute()
        {
            int x = 10;
            int y = 20;
            Figure f = new Figure(10, 20);
            f.Draw();
            Square s = new Square(10, 20);
            s.Draw();
            Rectangle r = new Rectangle(10, 20);
            r.Draw();

            IDrawable[] array = { f, s, r };
            DrawAll(array);
        }
    }
}
