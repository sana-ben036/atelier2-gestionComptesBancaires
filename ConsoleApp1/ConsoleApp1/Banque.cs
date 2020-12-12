using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Banque
    {
        // les champs
        public List<Compte> listComptes;

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


        public void AjouterCompteSurCarnet(int n1, int n, string p, decimal s)
        {
            bool exist = listComptes.Exists(compte => compte.GetNumero() == n);    // 
            if (exist == true)
            {
                Console.WriteLine("Le compte est déja enregistré"); ;
            }
            else
            {
                listComptes.Add(new CompteSurCarnet(n1, n, p, s));
            }

            
        }

        public void AjouterCompteSurCheque(int n1, int n2, string t, int n, string p, decimal s)
        {
            
            bool exist = listComptes.Exists(compte => compte.GetNumero() == n);    
            if (exist == true) 
            {
                Console.WriteLine("Le compte est déja enregistré"); ; 
            }
            else 
            {
                listComptes.Add(new CompteSurCheque(n1, n2, t, n, p, s));
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















    }
}
