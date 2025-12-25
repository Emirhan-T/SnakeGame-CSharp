using Raylib_cs;
using System;

namespace Snake_game
{
  class MyFrame
  {
    static Game_area game_Area= new Game_area();
    static Snake snake= new Snake();
    static Food food=new Food();
    static int score = 0;
    public static void Start()
    {
        Raylib.InitWindow(800,640,"Snake Game");
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
        {food.spawn_food();
            for(int i = 0; i < snake.body.Count; i++)
          {
            if(food.x_Cor==snake.body[i].x_axis && food.y_Cor == snake.body[i].y_axis)
            {
              food.spawn_food();
            }
          } 
          snake.Eat();
          score +=10 ;
        }

              counter+=1;
                      if (counter == 20)
                         {
                          
                            snake.Move();
                                    if(snake.body[0].x_axis>799 || snake.body[0].x_axis < 0||snake.body[0].y_axis>599 || snake.body[0].y_axis<0)
        {
          snake.Reset();
          score=0;
        }
        for(int i = 2;i < snake.body.Count; i++)
        {
          if(snake.body[0].x_axis==snake.body[i].x_axis && snake.body[0].y_axis==snake.body[i].y_axis)
          {
            snake.Reset();
            score=0;
          }
        }
                            counter=0;
                         }
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.Black);
                game_Area.DrawTiles();
                snake.DrawSnake();
                food.draw_food();
                Raylib.DrawText("Score: " + score, 20, 600, 40, Color.Blue);
                Raylib.EndDrawing();
            }
        Raylib.CloseWindow();
         
    }
  }
}