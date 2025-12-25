using Raylib_cs;
using System;

namespace Snake_game
{
  class MyFrame
  {
    static Game_area game_Area= new Game_area();
    static Snake snake= new Snake();
    static Food food=new Food();
    public static void Start()
    {
        Raylib.InitWindow(800,600,"Snake Game");
        Raylib.SetTargetFPS(60);
        int counter=0;
        
            while (!Raylib.WindowShouldClose())
            {
              if(Raylib.IsKeyPressed(KeyboardKey.W)&& snake.dirY != 1)
        {
          snake.dirX=0;
          snake.dirY=-1;
        }
        if(Raylib.IsKeyPressed(KeyboardKey.S)&& snake.dirY != -1)
        {
          snake.dirX=0;
          snake.dirY=1;
        }
        if(Raylib.IsKeyPressed(KeyboardKey.D)&& snake.dirX != -1)
        {
          snake.dirX=1;
          snake.dirY=0;
        }
        if(Raylib.IsKeyPressed(KeyboardKey.A)&& snake.dirX != 1)
        {
          snake.dirX=-1;
          snake.dirY=0;
        }
                if (snake.body[0].x_axis == food.x_Cor && snake.body[0].y_axis == food.y_Cor)
        {
            food.spawn_food(); 
        }
              counter+=1;
                      if (counter == 30)
                         {
                            snake.Move();
                            counter=0;
                         }
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.Black);
                game_Area.DrawTiles();
                snake.DrawSnake();
                food.draw_food();
                Raylib.EndDrawing();
            }
        Raylib.CloseWindow();
         
    }
  }
}