using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi.Models;
using System;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class GameTests
  {
    // Test methods go here
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      Game newGame = new Game("name");
      string resultName = newGame.Name;
      Assert.AreEqual(typeof(Game), newGame.GetType());
      Assert.AreEqual(resultName, "name");
    }

    [TestMethod]
    public void GetAll_ReturnsAllTamagotchisInGameList_Game1()
    {
      Game newGame1 = new Game("Game1");
      Game newGame2 = new Game("Game2");
      CollectionAssert.Contains(Game.GetAll(), newGame1);
    }

    
    [TestMethod]
    public void ClearAll_DeletesAllTamagotchisInGameList_EmptyList()
    {
      Game newGame1 = new Game("Game1");
      Game newGame2 = new Game("Game2");
      Game.ClearAll();
      CollectionAssert.DoesNotContain(Game.GetAll(), newGame1);
    }

    [TestMethod]
    public void Find_FindsAndReturnsGameBtIDNumber_Game()
    {
      Game newGame1 = new Game("Game1");
      Game newGame2 = new Game("Game2");
      Game foundGame = Game.Find(2);
      Assert.AreEqual(foundGame, newGame2);
    }

    [TestMethod]
    public void IncreaseFoodLevel_IncrementsFoodLevelByOne_Eleven()
    {
      Game newGame = new Game("Name");
      newGame.IncreaseFoodLevel();
      int result = newGame.FoodLevel;
      Assert.AreEqual(result, 11);
    }

    [TestMethod]
    public void IncreaseHappyLevel_IncrementsHappyLevelByOne_Eleven()
    {
      Game newGame = new Game("Name");
      newGame.IncreaseHappyLevel();
      int result = newGame.HappyLevel;
      Assert.AreEqual(result, 11);
    }

    [TestMethod]
    public void IncreaseRestedLevel_IncrementsRestedLevelByOne_Eleven()
    {
      Game newGame = new Game("Name");
      newGame.IncreaseRestedLevel();
      int result = newGame.RestedLevel;
      Assert.AreEqual(result, 11);
    }

    [TestMethod]
    public void IncreaseAllLevels_IncrementsAllLevelsByOne_Eleven()
    {
      Game newGame = new Game("Name");
      newGame.IncreaseAllLevels();
      int resultFood = newGame.FoodLevel;
      int resultHappy = newGame.HappyLevel;
      int resultRested = newGame.RestedLevel;
      Assert.AreEqual(resultFood, 11);
      Assert.AreEqual(resultHappy, 11);
      Assert.AreEqual(resultRested, 11);
    }

    [TestMethod]
    public void DecreaseFoodLevel_DecrementsFoodLevelByOne_Nine()
    {
      Game newGame = new Game("Name");
      newGame.DecreaseFoodLevel();
      int result = newGame.FoodLevel;
      Assert.AreEqual(result, 9);
    }

    [TestMethod]
    public void DecreaseHappyLevel_DecrementsHappyLevelByOne_Nine()
    {
      Game newGame = new Game("Name");
      newGame.DecreaseHappyLevel();
      int result = newGame.HappyLevel;
      Assert.AreEqual(result, 9);
    }

    [TestMethod]
    public void DecreaseRestedLevel_DecrementsRestedLevelByOne_Nine()
    {
      Game newGame = new Game("Name");
      newGame.DecreaseRestedLevel();
      int result = newGame.RestedLevel;
      Assert.AreEqual(result, 9);
    }

    [TestMethod]
    public void DecreaseAllLevels_DecrementsAllLevelsByOne_Nine()
    {
      Game newGame = new Game("Name");
      newGame.DecreaseAllLevels();
      int resultFood = newGame.FoodLevel;
      int resultHappy = newGame.HappyLevel;
      int resultRested = newGame.RestedLevel;
      Assert.AreEqual(resultFood, 9);
      Assert.AreEqual(resultHappy, 9);
      Assert.AreEqual(resultRested, 9);
    }
  }
}