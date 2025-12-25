using Raylib_cs;


namespace Snake_game
{
    class Food
    {
        Random rand= new Random();

        int size =50;

        public int x_Cor;
        public int y_Cor;


        public void creat_food()
        {
            spawn_food();
        }
         public void spawn_food()
        {
            int x_num=rand.Next(16);
            int y_num= rand.Next(12);
            x_Cor=x_num*size;
            y_Cor=y_num*size;
            
        }
        public void draw_food()
        {
            Raylib.DrawRectangle(x_Cor,y_Cor,size,size,Color.Green);
        }
    }
}