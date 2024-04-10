namespace Assignment_0409;

public class Ball
{
    public double Size { get; set; }
    public Color Color { get; set; }
    public int ThrownCount { get; set; }

    public Ball(int size, int red, int green, int blue, int alpha)
    {
        Size = size;
        Color = new Color(red, green, blue, alpha);
    }

    public Ball(int size, Color color)
    {
        Size = size;
        Color = color;
    }

    public void Pop()
    {
        Size = 0;
    }

    public void Throw()
    {
        if (Size != 0)
        {
            ThrownCount++;
        }
    }

    public int getThrownCount()
    {
        return ThrownCount;
    }
}
