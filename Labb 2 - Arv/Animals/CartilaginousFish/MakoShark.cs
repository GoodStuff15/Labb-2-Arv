namespace Labb_2___Arv
{
    internal class MakoShark : Shark
    {
        private bool _warmblooded;

        public bool Warmblooded { get => _warmblooded; set => _warmblooded = value; }

        public MakoShark()
        {
            Name = "Makohaj";
            Family = "Håbrandshajar";
            Habitat = "Tempererade och tropiska öppna hav";
            LifeExpectancy = 25;
            Sound = "Blubbeliblubb";
            TypeOfTeeth = "Avsmalnande, bakåtvända tänder";
            Warmblooded = true;
        }
        public void SpeedBurst()
        {
            Console.WriteLine($"The {Name} spots prey and increases its speed rapidly to over 70 KM/H!");
        }
    }
}
