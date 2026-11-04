namespace MohawkGame2D;

public class Flower
{
    int x;

    // Each flower keeps its own petal colour between frames.
    Color petals = Color.OffWhite;

    public Flower(int positionX)
    {
        x = positionX;
    }

    public void Water(Cloud cloud)
    {
        // Accept rain up to 28 pixels on either side of this flower's centre.
        if (cloud.x >= x - 28 && cloud.x <= x + 28)
        {
            petals = cloud.rain;
        }
    }

    public void DrawFlower()
    {
        Draw.FillColor = new Color(61, 116, 74);
        Draw.Rectangle(x - 3, 238, 6, 80);
        Draw.Circle(x + 9, 283, 9);

        Draw.FillColor = petals;
        Draw.Circle(x - 16, 238, 13);
        Draw.Circle(x + 16, 238, 13);
        Draw.Circle(x, 222, 13);
        Draw.Circle(x, 254, 13);

        // Draw the yellow centre last so it covers the inner edges of the petals.
        Draw.FillColor = new Color(255, 192, 64);
        Draw.Circle(x, 238, 10);
    }
}