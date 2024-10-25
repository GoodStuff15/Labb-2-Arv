namespace Labb_2___Arv
{
    internal class PineTree : Plant
    {
        private bool _isPyntad;
        public bool IsPyntad { get => _isPyntad; set => _isPyntad = value; }
        public PineTree()
        {
            Name = "Gran";
            Phylum = "Fröväxter";
            Classification = "Pinopsida";
            Family = "Tallväxter";
            IsPyntad = false;

        }

        public void Decorate()
        {
            if(DateTime.Now.Month == 12)
            {
                IsPyntad = true;

            }

            if(_isPyntad)
            {
                Console.WriteLine("Snart är julen här, granen står så grann i stugan!");
            }
            else
            {
                Console.WriteLine($"Vi får vänta med att klä granen i {12 - DateTime.Now.Month} månader till :(");
            }
        }
    }
}
