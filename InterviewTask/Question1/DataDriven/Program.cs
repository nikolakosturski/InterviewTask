/*using System;


namespace InterviewTask
{

    //DATA-DRIVEN APPROACH

    public class Animal
    {
        private string ime;
        private string zvuk;
        public Animal(string ime, string zvuk)
        {
            this.ime = ime;
            this.zvuk = zvuk;
        }

        public string getIme()
        {
            string Ime = ime;
            return Ime;
        }
        
        public string getZvuk()
        {
            string Zvuk = zvuk;
            return Zvuk;
        }
    }

    public class Versases { 
        public void OldMcDonald(string x,string y) { 

           Animal anim = new Animal(x,y);
         
            Console.WriteLine($"Old MacDonald had a farm, E I E I O,\n" +
                $"And on his farm, he had a {anim.getIme()}, E I E I O." +
                $"\nWith a {anim.getZvuk()},{anim.getZvuk()} here and a {anim.getZvuk()},{anim.getZvuk()} there," +
                $"\nHere a {anim.getZvuk()}, there a {anim.getZvuk()},everywhere a {anim.getZvuk()}, {anim.getZvuk()}." +
                "\nOld MacDonald had a farm, E I E I O.\n");

        }
    }
    internal class Program

    {

        static void Main(string[] args)
        {
            Versases v = new Versases();
            v.OldMcDonald("Cow", "Moo");
            v.OldMcDonald("Duck","Quack");
            v.OldMcDonald("Pig", "Oink");
            v.OldMcDonald("Cat", "Meow");
            v.OldMcDonald("Dog", "Bark");
  
        }
    } 
}
*/