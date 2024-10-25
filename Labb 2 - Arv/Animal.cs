namespace Labb_2___Arv
{
    internal class Animal : Eukaryotes
    {

        // Egenskaper för djur

        private int _lifeExpectancy;
        private string _sound = "Default Sound";

        // Properties

        public int LifeExpectancy { get => _lifeExpectancy; protected set => _lifeExpectancy = value; }
        public string Sound { get => _sound; protected set => _sound = value; }

        // Constructor
        public Animal()
        {
            LifeExpectancy = 0;
            Name += " Animal";
        }
        // Metoder

        public void Feed()
        {
            Console.WriteLine($"{Name} is consuming organic material!");
        }
        public void Breathe()
        {
            Console.WriteLine($"{Name} is breathing oxygen!");

        }
        public void Mate()
        {
            Console.WriteLine($"{Name} is reproducing sexually!");

        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} goes {Sound}!!!");
        }

    }
}
