using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Odtwarzacz
{
    class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player();
            newPlayer.Add(new HeavyMetalRock("Metallica", "Enter Sandman"));
            newPlayer.Add(new IndieAlternativeRock("Florence and the Machine", "Kiss with a Fist"));
            newPlayer.Play(0);
            newPlayer.Play(1);


            
            
            

        }
    }
}
