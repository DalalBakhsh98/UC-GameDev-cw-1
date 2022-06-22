using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hero information
            string heroName = "Vincent";
            int HeroH = 190;
            int HeroAge = 35;
            string HeroSuperP = "Elastic";

            //Viilain information
            string VillainName = "Abdu";
            int VillH = 150;
            int VillAge = 22;
            string VillSuperP = "Annoying";

            int agedifference = HeroAge - VillAge;

            Console.WriteLine("Hello My name is "+heroName+ " and my height is "+HeroH+ "and my age is "+HeroAge+" and my super power is"+HeroSuperP+"");
            Console.WriteLine("Hello My name is " + VillainName + " and my height is " + VillH + "and my age is " + VillAge + " and my super power is " + VillSuperP+"");
            Console.WriteLine("The age difference is "+ agedifference+" ");


            HeroAge = HeroAge + 5;
            VillSuperP = "None";



            Console.WriteLine("Hello My name is " + heroName + " and my height is " + HeroH + "and my age is " + HeroAge + " and my super power is" + HeroSuperP + "");
            Console.WriteLine("Hello My name is " + VillainName + " and my height is " + VillH + "and my age is " + VillAge + " and my super power is " + VillSuperP + "");
            Console.WriteLine("The age difference is " + agedifference + "");


        }
    }
}
