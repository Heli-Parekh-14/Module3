using ClassLibrary1;
using System;
using CA2 = ConsoleApp2;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;

            //class library[.net library] usage
            Class1 o = new Class1();        //class 1 belongs to class library 1
            int res = o.add(x, y);
            Console.WriteLine(res);

            //namespace usage
            CA2.Program.display();          //namespace in another solution/project-added reference,using alias=<namspace name>,use the namespace

            Console.Read();
        }
    }
}
