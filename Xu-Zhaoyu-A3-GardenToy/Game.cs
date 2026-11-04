namespace MohawkGame2D;

public class Game
{
    Cloud cloud = new Cloud();
    Meadow meadow = new Meadow();
    Flower left = new Flower(80);
    Flower middle = new Flower(200);
    Flower right = new Flower(320);

    public void Setup()
    {
        Window.SetTitle("Rain Garden | Arrows: move");
        Window.SetSize(400, 400);
        Draw.LineSize = 0;
    }

    public void Update()
    {
        cloud.Move();

        Window.ClearBackground(new Color(156, 198, 211));
        meadow.DrawMeadow();
        left.DrawFlower();
        middle.DrawFlower();
        right.DrawFlower();
        cloud.DrawCloud();
    }
}