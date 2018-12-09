using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

class AlternativeRock : Rock
{
    private string alternativeRockSound = "AlternativeRock";
    public AlternativeRock(string author, string title) : base(author, title)
    {
    }
    public override void Play()
    {

        base.Play();
        Console.WriteLine(this.alternativeRockSound);
        if (this.GetType() == typeof(AlternativeRock)) Console.WriteLine("============================================================================");

    }
}

