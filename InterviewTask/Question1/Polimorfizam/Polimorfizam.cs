
using System;
using System.Collections.Generic;


namespace InterviewTask
{
    //VTORO RESENIE ZA PRVOTO PRASANJE

    public abstract class Animall
    {

        public abstract string getName();
        public abstract string getSOund();

        

    }
   
   
    class Cow : Animall
    {
        public override string getName()
        {
            return ("Cow");
        }
        public override string getSOund()
        {
            return ("Moo");
        }      
    }

    class Duck : Animall
    {
        public override string getName()
        {
            return ("Duck");
        }
        public override string getSOund()
        {
            return ("Quack");
        }


    }

    class Pig : Animall
    {

        public override string getName()
        {
            return ("Pig");
        }
        public override string getSOund()
        {
            return ("Oink");
        }

    }

    class Dog : Animall
    {

        public override string getName()
        {
            return ("Dog");
        }
        public override string getSOund()
        {
            return ("Bark");
        }

    }

    class Cat : Animall
    {

        public override string getName()
        {
            return ("Cat");
        }
        public override string getSOund()
        {
            return ("Meow");
        }
    }

    abstract class PecatiKlasa
    {
        public static string Pecati(Animall animal)
        {
            string pecati ="Old MacDonald had a farm, E I E I O,\n" +
                $"And on his farm, he had a {animal.getName()}, E I E I O. \n" +
                $"With a {animal.getSOund()},{animal.getSOund()} here and a {animal.getSOund()},{animal.getSOund()} there,\n" +
                $"Here a {animal.getSOund()}, there a {animal.getSOund()}, everywhere a {animal.getSOund()} {animal.getSOund()}.\n" +
                $"Old MacDonald had a farm, E I E I O.\n";
            return (pecati);
        }
    }
    internal class Polimorfizam
    {
       
        static void Main(string[] args)
        {

            List<Animall> list = new List<Animall>();
            list.Add(new Cow());
            list.Add(new Duck());
            list.Add(new Pig());
            list.Add(new Dog());
            list.Add(new Cat());
          

            foreach (Animall animall in list)
            {
                var p = PecatiKlasa.Pecati(animall);
                Console.WriteLine(p);
            }
            
        }

        
    }
}
