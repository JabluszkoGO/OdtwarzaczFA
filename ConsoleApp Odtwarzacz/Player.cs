using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    private ArrayList trackList;
    public Player()
    {
        trackList = new ArrayList();
    }
    public void Add(Song song)
    {
        trackList.Add(song);
    }
    public void Remove(int songNumber)
    {
        trackList.Remove(songNumber);
    }
    public void Play(int songNumber)
    {
        ((Song)trackList[songNumber]).Play();
    }

}

