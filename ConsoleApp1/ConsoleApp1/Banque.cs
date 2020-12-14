using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Banque
    {
        // les champs
        public List<Compte> listComptes;
        public Compte compte;

        public Banque()
        {
            listComptes = new List<Compte>(); // declaration d'une list 

        }

        public void ChercherCompte(int numero)
        {

            Compte compte = listComptes.Find(compte => compte.GetNumero() == numero);

            if (compte != null)

                Console.WriteLine("l'index du compte recherché est : "+ listComptes.IndexOf(compte));
            else
            {
                Console.WriteLine(-1);
            }
       
        }


        public void AjouterCompteSurCarnet(Compte compte)
        {
            bool exist = listComptes.Exists(x => x.GetNumero() == compte.GetNumero());    // 
            if (exist == true)
            {
                Console.WriteLine("Le compte est déja enregistré"); ;
            }
            else
            {
                listComptes.Add(compte);
            }

            
        }

        public void AjouterCompteSurCheque(Compte compte)
        {
            
            bool exist = listComptes.Exists(x => x.GetNumero() == compte.GetNumero());    
            if (exist == true) 
            {
                Console.WriteLine("Le compte est déja enregistré"); ; 
            }
            else 
            {
                listComptes.Add(compte);
            }

        }

        public void DeleteCompte(int numero)
        {
            if (listComptes.Count > 0)
            {
                listComptes.RemoveAll(compte => compte.GetNumero() == numero);
            }
            else
            {
                Console.WriteLine("La list est vide");
            }
        }

        public void  GetInfoCompte(int numero)  // non determiner
        {
            Compte compte = listComptes.Find(compte => compte.GetNumero() == numero);
            if (compte != null)
            {
                Console.WriteLine(compte.GetInfo()); 
            }
            else
            {
                Console.WriteLine("Numero de compte est introuvable ");
            }
 
        }

        public void AfficherList()
        {
            foreach(Compte compte in listComptes)
            {
                Console.WriteLine(compte.GetInfo());
            }
        }


        public void OperationDebiter(int numero, decimal montant)
        {
            Compte compte = listComptes.Find(compte => compte.GetNumero() == numero);
            if (compte != null)
            {
                Console.WriteLine("Votre Numero de Compte  : " + compte.GetNumero());
                Console.WriteLine( "Votre Solde : "+compte.GetSolde() + " DH");
                Console.WriteLine("Le Montant Debité  : " + montant + " DH");
                compte.Debiter(montant);
                Console.WriteLine("Votre Nouveau Solde : " + compte.GetSolde() + " DH"); 
            }
            else
            {
                Console.WriteLine("Numero de compte est introuvable ");
            }
        }

        public void OperationCrediter(int numero, decimal montant)
        {
            Compte compte = listComptes.Find(compte => compte.GetNumero() == numero);
            if (compte != null)
            {
                Console.WriteLine("Votre Numero de Compte  : " + compte.GetNumero());
                Console.WriteLine("Votre Solde : " + compte.GetSolde() + " DH");
                Console.WriteLine("Le Montant Credité  : " + montant + " DH");
                compte.Crediter(montant);
                Console.WriteLine("Votre Nouveau Solde : " + compte.GetSolde() + " DH");
            }
            else
            {
                Console.WriteLine("Numero de compte est introuvable ");
            }
        }












    }
}
