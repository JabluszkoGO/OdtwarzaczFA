using System;
using System.Threading;

class Rock : Song
{
    private string rockSound = "Rock";
    public Rock(string author, string title) : base(author, title)
    {
    }
    public override void Play()
    {
        base.Play();
        Console.WriteLine(this.rockSound);
        if (this.GetType() == typeof(Rock)) Console.WriteLine("============================================================================");
    }
}

