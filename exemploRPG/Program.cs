using exemploRPG.SRC.Entities;

namespace exemploRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            System.Console.WriteLine(wizard.Attack(1));
            System.Console.WriteLine(wizard.Attack(7));
        }
    }
}
