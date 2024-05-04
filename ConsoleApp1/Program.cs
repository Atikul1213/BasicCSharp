using ConsoleApp1.Math;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Pig myPig = new Pig();
            myPig.animalSound();
            myPig.sleep();

            Console.ReadLine();
        }
 
    }


     public abstract class Animal
    {
        public abstract void animalSound();

        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

     public class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig say: wee wee");
        }
    }



     
}
