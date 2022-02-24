using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class SongTests : IDisposable
  {

    public void Dispose()
    {
      Song.ClearAll();
    }

    [TestMethod]
    public void SongConstructor_CreateInstanceOfSong_Song()
    {
      Song newSong = new Song("Rumble");
      Assert.AreEqual(typeof(Song), newSong.GetType());
    }

    [TestMethod]
    public void SongAddArtist_AddArtist_Song()
    {
      Song newSong = new Song("Insane");
      newSong.AddArtist("Dion Timmer");
      Assert.AreEqual("Dion Timmer", newSong.Artist);
    }
    
    [TestMethod]
    public void SongAddArtist_AddUnknownArtist_Song()
    {
      Song newSong = new Song("Unknown");
      newSong.AddArtist("");
      Assert.AreEqual("Unknown Artist", newSong.Artist);
    }


  }
}