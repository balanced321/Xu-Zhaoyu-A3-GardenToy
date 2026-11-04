namespace MohawkGame2D;

public class Game
{
    Meadow meadow = new Meadow();

    public void Setup()
    {
        Window.SetTitle("Rain Garden");
        Window.SetSize(400, 400);
        Draw.LineSize = 0;
    }

    public void Update()
    {
        Window.ClearBackground(new Color(156, 198, 211));
        meadow.DrawMeadow();
    }
}