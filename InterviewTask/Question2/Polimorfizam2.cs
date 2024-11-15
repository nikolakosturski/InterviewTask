using System;
using System.Collections.Generic;


namespace InterviewTask2
{

    //KOD ZA VTORO PRASNJE

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


    class Horse : Animall
    {

        public override string getName()
        {
            return ("Horse");
        }
        public override string getSOund()
        {
            return ("Neigh");
        }

    }

    class Sheep : Animall
    {

        public override string getName()
        {
            return ("Sheep");
        }
        public override string getSOund()
        {
            return ("Baa");
        }

    }

    class Turkey : Animall
    {

        public override string getName()
        {
            return ("Turkey");
        }
        public override string getSOund()
        {
            return ("Gobble");
        }

    }

    class Donkey : Animall
    {

        public override string getName()
        {
            return ("Donkey");
        }
        public override string getSOund()
        {
            return ("Hee-haw");
        }

    }

    class Dolphin : Animall
    {

        public override string getName()
        {
            return ("Dolphin");
        }
        public override string getSOund()
        {
            return ("Whistle");
        }

    }

    class Deer : Animall
    {

        public override string getName()
        {
            return ("Deer");
        }
        public override string getSOund()
        {
            return ("Bell");
        }

    }

    class Bear : Animall
    {

        public override string getName()
        {
            return ("Bear");
        }
        public override string getSOund()
        {
            return ("Roar");
        }

    }

    class Bee : Animall
    {

        public override string getName()
        {
            return ("Bee");
        }
        public override string getSOund()
        {
            return ("Buzz");
        }

    }


    class Tiger : Animall
    {

        public override string getName()
        {
            return ("Tiger");
        }
        public override string getSOund()
        {
            return ("Roar");
        }

    }

    class Chiken : Animall
    {

        public override string getName()
        {
            return ("Chicken");
        }
        public override string getSOund()
        {
            return ("Cluck");
        }

    }


    abstract class PecatiKlasa
    {
        public static string Pecati(Animall animal)
        {
            string pecati = "Old MacDonald had a farm, E I E I O,\n" +
                $"And on his farm, he had a {animal.getName()}, E I E I O. \n" +
                $"With a {animal.getSOund()},{animal.getSOund()} here and a {animal.getSOund()},{animal.getSOund()} there,\n" +
                $"Here a {animal.getSOund()}, there a {animal.getSOund()}, everywhere a {animal.getSOund()} {animal.getSOund()}.\n" +
                $"Old MacDonald had a farm, E I E I O.\n";
            return (pecati);
        }
    }

    internal class Polimorfizam2
    {

        static void Main(string[] args)
        {

           List <Animall> list = new List <Animall>();
            list.Add(new Cow());
            list.Add(new Duck());
            list.Add(new Pig());
            list.Add(new Dog());
            list.Add(new Cat());
            list.Add(new Horse());
            list.Add(new Sheep());
            list.Add(new Turkey());
            list.Add(new Donkey());
            list.Add(new Dolphin());
            list.Add(new Deer());
            list.Add(new Bear());
            list.Add(new Bee());
            list.Add(new Chiken());
            list.Add(new Tiger());

            foreach (Animall animal in list)
            {
                var p = PecatiKlasa.Pecati(animal);
                Console.WriteLine(p);
            }


        }
   
}
}
