namespace MohawkGame2D;

public class Meadow
{
    int groundY = 316;

    public void DrawMeadow()
    {
        Draw.FillColor = new Color(77, 137, 82);
        Draw.Rectangle(0, groundY, 400, 84);

        Draw.FillColor = new Color(103, 158, 91);
        for (int tuft = 0; tuft < 20; tuft++)
        {
            Draw.Circle(10 + tuft * 20, groundY, 10);
        }
    }
}