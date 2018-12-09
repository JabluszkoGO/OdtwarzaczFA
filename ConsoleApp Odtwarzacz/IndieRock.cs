using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

class IndieAlternativeRock : AlternativeRock
{
    private string indieAlternativeRockSound = "IndieAlternativeRock";
    public IndieAlternativeRock(string author, string title) : base(author, title)
    {
    }
    public override void Play()
    {

        base.Play();
        Console.WriteLine(this.indieAlternativeRockSound);
        if (this.GetType() == typeof(IndieAlternativeRock)) Console.WriteLine("============================================================================");

    }
}

