using Sharprompt;
using System.Collections;
using levelup;

namespace levelup.cli
{
    public class Map
        {           
           public static int numOfRowsAndColumns = 10;
           Position positions = new Position(numOfRowsAndColumns,numOfRowsAndColumns);
           Position startingPosition = new Position(5,5);

            public Map ()
            {

            }

           public int SetMapPosition(int x, int y)
           {
                return positions.SetPosition(x,y);
            }
        }
}