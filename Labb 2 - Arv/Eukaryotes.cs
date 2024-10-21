namespace Labb_2___Arv
{
    internal class Eukaryotes
    {
        private string _name;
        private string _phylum;
        private string _classification;
        private string _family;
        private string _habitat;
        public string Name { get => _name; set => _name = value; }
        public string Phylum { get => _phylum; set => _phylum = value; }
        public string Classification { get => _classification; set => _classification = value; }
        public string Family { get => _family; set => _family = value; }
        public string Habitat { get => _habitat; set => _habitat = value; }


        public Eukaryotes()
        {
            Name = "Default";
            Phylum = "Default";
            Classification = "Default";
            Family = "Default";
            Habitat = "Default";
        }
    }
}
