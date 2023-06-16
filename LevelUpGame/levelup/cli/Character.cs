using Sharprompt;
using System.Collections;
using levelup;
//using Map;

namespace levelup.cli
{
public class Character
{
    public static string name;
    public const string DEFAULT_CHARACTER_NAME = "Player 1";

    public string CreateCharacter(string characterName = DEFAULT_CHARACTER_NAME)
    {
       name = characterName;
       return name;
    }

    //public Character(string characterName)
    //{
    //    name = characterName;
    //}

    public string GetName()
    {
       // if name is null(
       //    return DEFAULT_CHARACTER_NAME;
      //  )
       // else
      //  (
            return name;
      //  )
    }

    public void EnterMap (Map map)
    {

    }

   public Position GetPosition ()
   {
    // Update later to pull from Game Map
    Position position = new Position(2, 3);
    return position;
   }

 // public void Move(DIRECTION direction)
  //{}
}
}