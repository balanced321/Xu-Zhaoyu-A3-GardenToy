namespace MohawkGame2D;

public class Cloud
{
    public float x = 200;
    public Color rain = Color.Cyan;

    public void DrawCloud()
    {
        Draw.FillColor = Color.White;
        Draw.Circle(x - 20, 85, 19);
        Draw.Circle(x, 74, 25);
        Draw.Circle(x + 20, 85, 19);
        Draw.Rectangle(x - 20, 85, 40, 18);

        // The drops show where the rain will land.
        Draw.FillColor = rain;
        for (int drop = 0; drop < 5; drop++)
        {
            Draw.Circle(x, 120 + drop * 19, 4);
        }
    }
}