/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTask.Question3
{
    // KOD ZA TRETO PRASANJE
    public class Animal
    {
        private string ime;
        private string zvuk;
        public string getIme()
        {
            string Ime = ime;
            return Ime;
        }
        public void setIme(string Ime)
        {
            this.ime = Ime;
        }
        public string getZvuk()
        {
            string Zvuk = zvuk;
            return Zvuk;
        }

        public void setZvuk(string Zvuk)
        {
            this.zvuk = Zvuk;
        }
        public void OldMcDonald()
        {
            Console.WriteLine($"Old MacDonald had a farm, E I E I O,\n" +
                $"And on his farm, he had a {getIme()}, E I E I O." +
                $"\nWith a {getZvuk()},{getZvuk()} here and a {getZvuk()},{getZvuk()} there," +
                $"\n Here a {getZvuk()}, there a {getZvuk()}, everywhere a {getZvuk()} {getZvuk()}." +
                "\nOld MacDonald had a farm, E I E I O.\n");

        }
    }

    internal class UserInput
    {
        static void Main(string[] args)
        {



        Start:
            Console.WriteLine("Vnesete ime na zivotno: ");
            string Ime = Console.ReadLine();
            Console.WriteLine("Vnesete zvuk za vaseto zivotno: ");
            string zvuk = Console.ReadLine();

            Animal zivotno = new Animal();

            zivotno.setIme(Ime);
            zivotno.setZvuk(zvuk);
            zivotno.OldMcDonald();
            Console.Write("Dali sakate da vnesete novo zivotno?y/n\n");
            Odgovor:
            string odgovor = Console.ReadLine();
           
              if (odgovor == "y")
            {
                goto Start;
            }
              else if (odgovor == "n")
            {
                System.Environment.Exit(0);
            }
             else if (odgovor != "y" || odgovor != "n")
            {
                Console.WriteLine("Ve molime odgovorete so y ili n");
                goto Odgovor;
            }

        }
    }
}
*/