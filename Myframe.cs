using Raylib_cs;
using System;

namespace Snake_game
{
  class MyFrame
  {
    static Game_area game_Area= new Game_area();
    static Snake snake= new Snake();
    public static void Start()
    {
        Raylib.InitWindow(800,600,"Snake Game");
        Raylib.SetTargetFPS(60);
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);
                game_Area.DrawTiles();
                snake.DrawSnake();
                Raylib.EndDrawing();
            }
        Raylib.CloseWindow();
         
    }
  }
}