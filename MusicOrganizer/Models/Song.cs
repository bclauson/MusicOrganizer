using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Song
  {
    public string Name { get; set; }
    public int Id { get; }
    public string Artist { get; set; }
    private static List<Song> _instances = new List<Song> {};

    public Song(string name)
    {
      Name = name;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public void AddArtist(string artist)
    {
      if (artist == "")
      {
        Artist = "Unknown Artist";
      }
      else 
      {
        Artist = artist;
      }

    }


    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Song> GetAll()
    {
      return _instances;
    }
  }
}