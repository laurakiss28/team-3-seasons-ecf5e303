using Sharprompt;
using System.Collections;
namespace levelup.cli;
class Character
{
    public static string name;
    public static string DEFAULT_CHARACTER_NAME = "Player 1";

    public Character()
    {
    }

    public Character(string characterName)
    {
        name = characterName;
    }

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

   // public void EnterMap (GameMap map)
   // {}

  // public GetPosition ()
 //  {
   // return position;
  // }

 // public void Move(DIRECTION direction)
  //{}
}