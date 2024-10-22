
namespace Labb_2___Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animal = new Animal();
            var bear = new Bear();
            var shark = new Shark();
            var spider = new Spider();
            var mako = new MakoShark();
            var wobb = new Wobbegong();
            var gran = new PineTree();


            animal.MakeSound();
            bear.MakeSound();
            spider.MakeSound();
            mako.MakeSound();
            wobb.MakeSound();
            wobb.Hide();
            gran.Decorate();

            bear.Feed(bear.FatReserves);


        }
    }
}
