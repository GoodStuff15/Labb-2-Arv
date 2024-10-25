namespace Labb_2___Arv
{
    internal class Shark : Animal
    {
        private string _typeOfTeeth;

        public string TypeOfTeeth { get => _typeOfTeeth; set => _typeOfTeeth = value; }

        public Shark()
        {
            Phylum = "Ryggsträngsdjur";
            Classification = "Broskfiskar";
            TypeOfTeeth = "Default";
            Name += "(Shark)";
        }
        private void SensePrey()
        {

        }
    }
}
