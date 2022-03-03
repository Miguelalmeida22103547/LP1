using System;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
			foreach(string s in args){
				Console.WriteLine(" -------  ");
				Console.WriteLine(s);
			}
            //Console.WriteLine("Hello World!");
			//Console.WriteLine("Bye World!!");
        }
    }
}
