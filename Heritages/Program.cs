using System;

namespace Heritages
{
    class Program
    {
        static void Main(string[] args)
        {
            IRenouvelable cate1 = new Carte(2222,123);
            IRenouvelable chequier1 = new Chequier(2222);

            DateTime d =  cate1.DateRenouvellemnet;
            Console.WriteLine(d);
        }
    }
}
