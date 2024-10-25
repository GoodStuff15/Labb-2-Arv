namespace Labb_2___Arv
{
    internal abstract class Eukaryotes
    {
        private string _name = "Default";
        private string _phylum = "Default";
        private string _classification = "Default";
        private string _family = "Default";
        private string _habitat = "Default";
        public string Name { get => _name; set => _name = value; }
        public string Phylum { get => _phylum; set => _phylum = value; }
        public string Classification { get => _classification; set => _classification = value; }
        public string Family { get => _family; set => _family = value; }
        public string Habitat { get => _habitat; set => _habitat = value; }


        public Eukaryotes()
        {
 
        }
    }
}
