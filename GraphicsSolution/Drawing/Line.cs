namespace Drawing;

public class Line :Shape, IDisplay
{
    public Point StartPoint { get; set; }
    public Point EndPoint { get; set; }

    public Line()
    {
        this.StartPoint = new Point(0, 0);
        this.EndPoint = new Point(0, 0);
    }

    public Line(Point initial, Point final)
    {
        this.StartPoint = initial;
        this.EndPoint = final;
    }

    public void Display()
    {
        Console.WriteLine("(" + this.StartPoint + "), (" + this.EndPoint + "),");
    }
}
