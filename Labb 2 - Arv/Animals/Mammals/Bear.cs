namespace Labb_2___Arv
{
    internal class Bear : Mammal
    {
        private string _furColor;
        private int _fatReserves;

        public string FurColor { get => _furColor; set => _furColor = value; }
        public int FatReserves 
        { 
            get { return _fatReserves; }
            
            set { switch(value)
                {
                    case 1:
                        _fatReserves = 50;
                        break;
                    case 2:
                        _fatReserves = 30;
                        break;
                    case 3:
                        _fatReserves = 10;
                        break;
                    case 4:
                        _fatReserves = 0;
                        break;
                    case 5:
                        _fatReserves = 10;
                        break;
                    case 6:
                        _fatReserves = 30;
                        break;
                    case 7:
                        _fatReserves = 50;
                        break;
                    case 8:
                        _fatReserves = 75;
                        break;
                    case 9:
                        _fatReserves = 100;
                        break;
                    case 10:
                        _fatReserves = 100;
                        break;
                    case 11:
                        _fatReserves = 90;
                        break;
                    case 12:
                        _fatReserves = 70;
                        break;
                }  
                    
                 }
                
         }

        public Bear()
        {
            Name = "Björn";
            Family = "Björnar";
            Habitat = "Land";
            LifeExpectancy = 30;
            Sound = "GGRRRRARRORORRRRHHH";
            FurColor = "Default";
            FatReserves = DateTime.Now.Month;
        }
        public void Swim()
        {
            Console.WriteLine($"{Name} is going for a swim!");
        }

        // Overloaded Feed method
        public void Feed(int fat)
        {
            if(fat == 100)
            {
                Console.WriteLine($"{Name} is full and ready for hibernation!");
            }
            else
            {
                Console.WriteLine("NAMNAM need more blueberries!!");
            }
        }

    }
}
