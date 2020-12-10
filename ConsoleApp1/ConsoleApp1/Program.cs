using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Banque banque = new Banque();
                banque.AjouterCompteSurCarnet(1001, 100, "sana", 100);
                banque.AjouterCompteSurCheque(1002,56356,"10 octobre 2022",100, "sana", 2000);


            }
            catch (Exception)
            {
                Console.WriteLine("VOTRE SOLDE EST INSSUFISSANT");
            }


        }
    }
}
