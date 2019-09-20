using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Threading;

namespace EPAM_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] times = new int[] { 4, 15, 27, 38, 52, 65, 79, 95, 111, 130};
            string caption = "Песня про циплёнка пиу-пиу :3";
            Stopwatch sw = new Stopwatch();
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "Music.wav";
            player.Load();
            player.Play();
            sw.Start();
            FairyTale tale = new FairyTale();

            Console.WriteLine(caption);
            Console.WriteLine();
            while (!tale.IsEnded)
            {
                Thread.Sleep((int)Math.Max(times[tale.CurrentCharacterIndex] * 1000 - sw.ElapsedMilliseconds, 0));
                tale.NextStep();
            }

            Console.ReadLine();
        }
    }
}
