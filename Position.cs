namespace SnakeConsole
{
    public class Position
    {    
        private int x, y;

        public Position(){}
        public Position(int x, int y) {  this.x = x; this.y = y; }

        public int X { get { return this.x;} set { this.x = value;} }
        public int Y { get { return this.y; } set { this.y = value; } }
    }
}