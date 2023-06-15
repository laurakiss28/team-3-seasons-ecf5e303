namespace levelup
{
    public class Position
    {

        // Properties
        public int X { get; private set; }
        public int Y { get; private set; }

        // Constructor
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Position()
        {

        }



        // Methods
        public int SetPosition(int x, int y)
        {
            X = x;
            Y = y;

            return X;
        }
    }
}