using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
  public class GamesController : Controller
  {
    [HttpGet("/games")]
    public ActionResult Index() { return View(); }

    [HttpGet("/games/new")]
    public ActionResult New() { return View(); }

    [HttpPost("/games")]
    public ActionResult Create(string param) 
    { 
      Game myGame = new Game(param);
      return View(); 
    }

  }
}