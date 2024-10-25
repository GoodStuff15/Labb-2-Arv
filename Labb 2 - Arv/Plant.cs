namespace Labb_2___Arv
{
    internal class Plant : Eukaryotes
    {
        public Plant()
        {
            Name += " Plant";

        }

        public void Photosynthesis()
        {
            Console.WriteLine($"{Name} turned carbon dioxide, water and energy from the sun into oxygen and glucose!");
        }
    }
}
