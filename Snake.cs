
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using Raylib_cs;

namespace Snake_game
{
    public class Snake
    {
        public List<parts> body= new List<parts>();
        public int dirX=1;
        public int dirY=0;
        public int Size=50;

        public void Move()
        {
            body[0].x_axis+= (dirX*Size);
            body[0].y_axis+=(dirY*Size);
        }

        public Snake()
        {
            body.Add(new parts(400,300));
        }
        public void DrawSnake()
        {
            foreach (parts i in body)
            {
                Raylib.DrawRectangle(i.x_axis, i.y_axis, Size, Size, Color.Red);
            }
        }
  
    }
    public class parts
    {
        public int x_axis;
        public int y_axis;
        public parts(int x, int y)
        {
            this.x_axis = x;
            this.y_axis = y;
        }
    }
}

