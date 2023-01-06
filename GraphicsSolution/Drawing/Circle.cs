namespace Drawing;

public class Circle
{
    public Point Center { get; set; }
    public int radius { get; set; }

    public Circle()
    {
        this.Center = new Point(0, 0);
        this.radius = 1;
    }

    public Circle(Point c, int r)
    {
        this.Center = c;
        this.radius = r;
    }
}
