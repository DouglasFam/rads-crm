using Data.Repository;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteRepository rep = new ClienteRepository();


            var teste = rep.Select(4);
        }
    }
}
