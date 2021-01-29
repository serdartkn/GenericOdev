using System;

namespace GenericOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> isimYas = new MyDictionary<string, int>();
            isimYas.Add("Serdar", 24);
            isimYas.Add("Sesdardar", 234);
        }
    }
}
