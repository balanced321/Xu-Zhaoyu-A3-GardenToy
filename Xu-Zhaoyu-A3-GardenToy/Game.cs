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
        // Setup runs once. The window matches the 400 x 400 plan.
        Window.SetTitle("Rain Garden | Arrows: move | Click: water | W: colour");
        Window.SetSize(400, 400);
        Draw.LineSize = 0;
    }

    public void Update()
    {
        // Read movement and colour before checking where this click lands.
        cloud.Move();
        cloud.ChooseRain();

        // A single press asks each flower to check its distance from the cloud.
        if (Input.IsMouseButtonPressed(MouseButton.Left))
        {
            left.Water(cloud);
            middle.Water(cloud);
            right.Water(cloud);
        }

        Window.ClearBackground(new Color(156, 198, 211));
        meadow.DrawMeadow();
        left.DrawFlower();
        middle.DrawFlower();
        right.DrawFlower();
        cloud.DrawCloud();
    }
}