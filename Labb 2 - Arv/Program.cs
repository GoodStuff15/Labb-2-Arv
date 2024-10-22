
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


            animal.MakeSound();
            bear.MakeSound();
            shark.MakeSound();
            spider.MakeSound();
            mako.MakeSound();
            wobb.MakeSound();

            bear.Feed(bear.FatReserves);
            Console.WriteLine(bear.Classification);
        }
    }
}
