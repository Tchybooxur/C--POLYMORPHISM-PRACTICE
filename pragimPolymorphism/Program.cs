using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pragimPolymorphism
{
    // Polymorphism is one of the primary pillars of Object Oriented Programming.
    // Polymorphism allows you to invoke derived class methods through a base class reference at runtime
    public class Stormer
    {
        public string userName = "Default";
        public string strength = "Default";

        public void printUserMoto()
        {
            Console.WriteLine("{0} is a devout sololearner who does {1} storms.", userName, strength);
        }
    }

    public class User1 : Stormer                
    {
    }

    public class User2 : Stormer
    {

    }

    public class User3 : Stormer
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stormer[] player = new Stormer[4];
            player[0] = new Stormer();
            player[1] = new User1();
            player[2] = new User2();
            player[3] = new User3();

            foreach(Stormer stm in player)
            {
                stm.printUserMoto();
            }

            Console.ReadKey();
        }
    }
}
