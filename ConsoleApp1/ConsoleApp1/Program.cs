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
                //bq.AjouterCompteSurCarnet(123,1003,"salima",1000);
                bq.AjouterCompteSurCarnet(150, 2089, "sana", 500);
                //bq.AjouterCompteSurCheque(1002, 56356, "10 octobre 2022", 302, "ilham", 2000);
                //bq.AjouterCompteSurCheque(1003, 87976, "10 octobre 2022", 300, "karim", 2300);
                //bq.AfficherList();
                //bq.ChercherCompte(2089);
                //bq.DeleteCompte(2089);
                //bq.AfficherList();
                 bq.ChercherCompte(2089);
                //bq.AfficherList();
                bq.GetInfoCompte(2089);


            }
            catch (Exception )
            {
                Console.WriteLine("error");
            }


        }
    }
}
