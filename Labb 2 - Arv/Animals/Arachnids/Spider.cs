using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Spider : Animal
    {
        private int _eyeCount;

        public int EyeCount { get => _eyeCount; set => _eyeCount = value; }

        public Spider()
        {
            Name = "Spindel";
            Phylum = "Leddjur";
            Classification = "Spindeldjur";
            EyeCount = 8;
            Sound = "tkatkatkatkatkatka";
        }

        private void spinSilk()
        {
            Console.WriteLine($"{Name}n spinner silke med sin silkeskörtel.");
        }
    }
}
