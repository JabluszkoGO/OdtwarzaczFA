using System;

abstract class Song
{
    protected string title { get; private set; }
    protected string author { get; private set; }
    protected Song(string author, string title)
    {
        this.title = title;
        this.author = author;
    }

    virtual public void Play()
    {
        Console.WriteLine("Obecnie gra utwór [{0}] wykonawcy [{1}]", this.title, this.author);
        Console.WriteLine("Brzmienie piosenki: ");
    }
}
