using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Wobbegong : Shark
    {
        private string _camouflage;

        public string Camouflage { get => _camouflage; set => _camouflage = value; }

        public Wobbegong()
        {
            Name = "Wobbegong";
            Family = "Wobbegonghajar";
            Habitat = "Grunt, tempererat eller tropiskt vatten";
            LifeExpectancy = 25;
            Sound = "Blubb blubb";
            TypeOfTeeth = "Långsmala och vassa";
            Camouflage = "Fläckigt skinn och växtliknande skäggtömmar";
        }

        public void Hide()
        {
            Console.WriteLine($"The {Name} hides using its {Camouflage}");
        }
    }
}
