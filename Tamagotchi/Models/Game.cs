using System;
using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Game
  {    
    public string Name { get; set; }
    public int FoodLevel { get; set; }
    public int HappyLevel { get; set; }
    public int RestedLevel { get; set; }
    public int Id { get; }
    private static List<Game> _instances = new List<Game>() {};

    public Game(string name)
    {
      Name = name;
      FoodLevel = 10;
      HappyLevel = 10;
      RestedLevel = 10;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Game> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Game Find(int id)
    {
      return _instances[id-1];
    }

    public void IncreaseFoodLevel()
    {
      FoodLevel++;
    }

    public void IncreaseHappyLevel()
    {
      HappyLevel++;
    }

    public void IncreaseRestedLevel()
    {
      RestedLevel++;
    }

    public void IncreaseAllLevels()
    {
      IncreaseFoodLevel();
      IncreaseHappyLevel();
      IncreaseRestedLevel();
    }

    public void DecreaseFoodLevel()
    {
      FoodLevel -= 1;
    }

    public void DecreaseHappyLevel()
    {
      HappyLevel -= 1;
    }

    public void DecreaseRestedLevel()
    {
      RestedLevel -= 1;
    }

    public void DecreaseAllLevels()
    {
      DecreaseFoodLevel();
      DecreaseHappyLevel();
      DecreaseRestedLevel();
    }
  }
}