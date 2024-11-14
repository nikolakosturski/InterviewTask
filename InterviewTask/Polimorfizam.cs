using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTask
{
    //VTORO RESENIE ZA PRVOTO PRASANJE
    public   class Animall
    {
        

  
        public virtual void OldMcDonaldd(string ime, string zvuk) { }

    }

    class Cow : Animall
    {
       


        public override void OldMcDonaldd(string ime,string zvuk)
        {

            Console.WriteLine("Old MacDonald had a farm, E I E I O,\n" +
                $"And on his farm, he had a {ime}, E I E I O. \n"+
                $"With a {zvuk},{zvuk} here and a {zvuk},{zvuk} there,\n"+
                $"Here a {zvuk}, there a {zvuk}, everywhere a {zvuk} {zvuk}.\n"+  
                $"Old MacDonald had a farm, E I E I O.\n");
        }
    
    
    }

        class Duck : Animall
    {

        public override void OldMcDonaldd(string ime, string zvuk)
        {

            Console.WriteLine("Old MacDonald had a farm, E I E I O,\n" +
                $"And on his farm, he had a {ime}, E I E I O. \n" +
                $"With a {zvuk},{zvuk} here and a {zvuk},{zvuk} there,\n" +
                $"Here a {zvuk}, there a {zvuk}, everywhere a {zvuk} {zvuk}.\n" +
                $"Old MacDonald had a farm, E I E I O.\n");
        }

    }


        class Pig : Animall
    {
        public override void OldMcDonaldd(string ime, string zvuk)
        {

            Console.WriteLine("Old MacDonald had a farm, E I E I O,\n" +
                $"And on his farm, he had a {ime}, E I E I O. \n" +
                $"With a {zvuk},{zvuk} here and a {zvuk},{zvuk} there,\n" +
                $"Here a {zvuk}, there a {zvuk}, everywhere a {zvuk} {zvuk}.\n" +
                $"Old MacDonald had a farm, E I E I O.\n");
        }
    }


    class Dog : Animall
    {

        public override void OldMcDonaldd(string ime, string zvuk)
        {

            Console.WriteLine("Old MacDonald had a farm, E I E I O,\n" +
                $"And on his farm, he had a {ime}, E I E I O. \n" +
                $"With a {zvuk},{zvuk} here and a {zvuk},{zvuk} there,\n" +
                $"Here a {zvuk}, there a {zvuk}, everywhere a {zvuk} {zvuk}.\n" +
                $"Old MacDonald had a farm, E I E I O.\n");
        }

    }


    class Cat : Animall
    {

        public override void OldMcDonaldd(string ime, string zvuk)
        {

            Console.WriteLine("Old MacDonald had a farm, E I E I O,\n" +
                $"And on his farm, he had a {ime}, E I E I O. \n" +
                $"With a {zvuk},{zvuk} here and a {zvuk},{zvuk} there,\n" +
                $"Here a {zvuk}, there a {zvuk}, everywhere a {zvuk} {zvuk}.\n" +
                $"Old MacDonald had a farm, E I E I O.\n");
            
         
        }

    }


        internal class Polimorfizam
        {
        
        static void Main(string[] args)
        {

            Cow c = new Cow();
            c.OldMcDonaldd("Cow","Moo");

            Duck d = new Duck();
            d.OldMcDonaldd("Duck", "Quack");

            Pig g = new Pig();
            g.OldMcDonaldd("Pig", "Oink");

            Dog a = new Dog();
            a.OldMcDonaldd("Dog", "Bark");

            Cat t = new Cat();
            t.OldMcDonaldd("Cat", "Meow");

        }
            
        
        


        }
    }
