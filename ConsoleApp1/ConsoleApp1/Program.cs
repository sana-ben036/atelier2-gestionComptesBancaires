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
                bq.AjouterCompteSurCarnet(123,1003,"salima",20000);
                bq.AjouterCompteSurCarnet(150, 2089, "sana", 500);
                bq.AjouterCompteSurCheque(1002, 56356, "10 octobre 2022", 302, "ilham", 2000);
                bq.AjouterCompteSurCheque(1003, 87976, "10 octobre 2022", 300, "karim", 2300);
                bq.AfficherList();
                Console.WriteLine("---------------fin affichage de list---------------------------");

                bq.ChercherCompte(2089);
                Console.WriteLine("---------------fin de recuperer l'indice de compte---------------------------");

                bq.DeleteCompte(2089);
                bq.AfficherList();
                Console.WriteLine("---------------fin verifier notre delet compte---------------------------");
                bq.ChercherCompte(2089);
                Console.WriteLine("---------------fin chercher le compte suprimé--------------------------");
                bq.GetInfoCompte(302);
                Console.WriteLine("---------------fin afficher info d'un compte donnee---------------------------");
                bq.OperationDebiter(1003, 10500);
                Console.WriteLine("---------------fin d'une operation debiter compte--------------------------");
                bq.OperationCrediter(302, 300);
                Console.WriteLine("---------------fin d'une operation crediter compte--------------------------");



            }
            catch (Exception ex )
            {
                Console.WriteLine("error : {0}." , ex.Message);
            }
           


        }
    }
}
