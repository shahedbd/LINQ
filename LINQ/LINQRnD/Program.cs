using System;
using LINQRnD.Model;

namespace LINQRnD
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = JSONReader.GetAll();
            Console.WriteLine("Hello World!");
        }
    }
}
