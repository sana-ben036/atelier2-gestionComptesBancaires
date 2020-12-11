using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Banque bq = new Banque();
                bq.AjouterCompteSurCarnet(1001, 100, "sana", 1000);
                bq.AjouterCompteSurCheque(1002,56356,"10 octobre 2022",100, "sana", 2000);
                //bq.AfficherList();
                //bq.GetInfoCompte(100);


            }
            catch (Exception ex)
            {
                Console.WriteLine("Votre operation est annulée : " + ex.Message);
            }


        }
    }
}
