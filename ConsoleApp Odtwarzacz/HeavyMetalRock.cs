using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

class HeavyMetalRock : Rock
{
    private string heavyMetalRockSound = "HeavyMetalRock";
    public HeavyMetalRock(string author, string title) : base(author, title)
    {
    }
    public override void Play()
    {

        base.Play();
        Console.WriteLine(this.heavyMetalRockSound);
        if (this.GetType() == typeof(HeavyMetalRock)) Console.WriteLine("============================================================================");

    }
}

