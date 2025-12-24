using Raylib_cs;

namespace Snake_game
{
    class Game_area
    {
        int tilesize=50;
        
       public void DrawTiles()
        {
            for(int i=0; i < 800/tilesize; i++)
            {
                for(int j = 0; j < 600/tilesize; j++)
                {
                    Raylib.DrawRectangleLines(i*tilesize,j*tilesize,tilesize,tilesize,Color.Gray);
                }
            }
        }
    }
}

