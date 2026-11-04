namespace MohawkGame2D;

public class Flower
{
    int x;
    Color petals = Color.OffWhite;

    public Flower(int positionX)
    {
        x = positionX;
    }

    public void Water(Cloud cloud)
    {
        // Only the flower underneath the cloud changes colour.
        if (cloud.x >= x - 28 && cloud.x <= x + 28)
        {
            petals = cloud.rain;
        }
    }

    public void DrawFlower()
    {
        // Stem and leaf
        Draw.FillColor = new Color(61, 116, 74);
        Draw.Rectangle(x - 3, 238, 6, 80);
        Draw.Circle(x + 9, 283, 9);

        // Four petals around the same centre
        Draw.FillColor = petals;
        Draw.Circle(x - 16, 238, 13);
        Draw.Circle(x + 16, 238, 13);
        Draw.Circle(x, 222, 13);
        Draw.Circle(x, 254, 13);

        Draw.FillColor = new Color(255, 192, 64);
        Draw.Circle(x, 238, 10);
    }
}