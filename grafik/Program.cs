using System;
using Raylib_cs;

namespace grafik
{
    class Program
    {
        static void Main(string[] args)
        {


            Raylib.InitWindow(800, 600, "test");

            float x = 0;
            float y = 0;

            while (!Raylib.WindowShouldClose())
            {

                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                    x += 0.1f;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                {
                    y += 0.1f;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                    x -= 0.1f;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {
                    y -= 0.1f;
                }

                Raylib.BeginDrawing();

                // Color myNewColor = new Color(124, 255, 12, 255);

                Raylib.ClearBackground(Color.WHITE);

                Raylib.DrawRectangle((int)x, (int)y, 50, 50, Color.PINK);
                Raylib.DrawRectangle((int)x + 5, (int)y + 35, 40, 5, Color.BLACK);




                Raylib.EndDrawing();
            }

        }
    }
}
