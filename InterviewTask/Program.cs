using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTask
{

    public class Animal
    {
        string ime;
        string zvuk;
      public string getIme()
        {
            string Ime = ime;
            return Ime;
        }
        public void setIme(string Ime)
        {
            this.ime = Ime;
        }
        public string getZvuk() { 
        string Zvuk =  zvuk;
        return Zvuk;
        }

        public void setZvuk(string Zvuk)
        {
            this.zvuk = Zvuk;
        }
        public void OldMcDonald()
        {   
            Console.WriteLine($"Old MacDonald had a farm, E I E I O,\nAnd on his farm, he had a {getIme()}, E I E I O." +
                $"\nWith a {getZvuk()},{getZvuk()} here and a {getZvuk()},{getZvuk()} there," +
                $"\n Here a {getZvuk()}, there a {getZvuk()}, everywhere a {getZvuk()} {getZvuk()}." +
                "\nOld MacDonald had a farm, E I E I O.\n");

        }
    }
    internal class Program


    {

      

        static void Main(string[] args)
        {

            Animal animal = new Animal();
            string zivotno1="cow";
            animal.setIme( zivotno1);
            string CowSound = "Moo";
            animal.setZvuk(CowSound);
            animal.OldMcDonald();

            string zivotno2 = "duck";
            animal.setIme(zivotno2);
            string duckSound = "Quack";
            animal.setZvuk(duckSound);
            animal.OldMcDonald();

            string zivotno3 = "pig";
            animal.setIme(zivotno3);
            string pigSound = "Oink";
            animal.setZvuk(pigSound);
            animal.OldMcDonald();

            string zivotno4 = "cat";
            animal.setIme(zivotno4);
            string CatSound = "Meow";
            animal.setZvuk(CatSound);
            animal.OldMcDonald();

            string zivotno5 = "dog";
            animal.setIme(zivotno5);
            string DogSOund = "Bark";
            animal.setZvuk(DogSOund);
            animal.OldMcDonald();
            


        }
    }
}
