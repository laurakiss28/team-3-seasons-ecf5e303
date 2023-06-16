using Sharprompt;
using System.Collections;
using levelup;

namespace levelup.cli
{
  public class Character
  {   
    public string? Name { get; set; }
    public Position? Position { get; set; }
    public Map? map { get; set; }

    public int moveCount { get; set; }
    public const string DEFAULT_CHARACTER_NAME = "Player 1";

      public Character(string characterName = DEFAULT_CHARACTER_NAME)
      {
        this.Name = characterName;
        this.moveCount = 0;
      }

      public void EnterMap (Map map)
    {
        this.map = map;
        this.Position = map.startingPosition;
      }

    public virtual void Move(GameController.DIRECTION direction)
      {
       if (this.map != null)
      {
          this.Position = map.CalculateNewPosition(this.Position, direction);
        this.moveCount+=1;
      }
     else {
      this.Position = null;
      }
     }
  }
}