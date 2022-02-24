using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
  public class SongController : Controller
  {

    [HttpGet("/song")]
    public ActionResult Index()
    {
      List<Song> allSongs = Song.GetAll();

      return View(allSongs);
    }

    [HttpGet("/song/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/song")]
    public ActionResult Create(string songName, string songArtist)
    {
      Song newSong = new Song(songName);
      if (songArtist == null)
      {
        songArtist = "";
      }
      newSong.AddArtist(songArtist);
      return RedirectToAction("Index");
    }

    [HttpPost("/song/delete")]
    public ActionResult DeleteAll()
    {
      Song.ClearAll();
      return View();
    }
  }
}