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

        /*public int ChercherCompte(int numero)
        {


            foreach (Compte compte in listComptes)
            {
                if (compte.GetNumero() == numero)
                {
                    int indice = listComptes.IndexOf(compte);
                    return indice;

                }
                else
                {
                    Console.WriteLine(-1);
                }
                
            }
            
        }*/


        public void AjouterCompteSurCarnet(int n1, int n, string p, decimal s)
        {
            foreach(CompteSurCarnet compte in listComptes)
            {
                if(compte.GetNumeroCarnet() == n1)
                {
                    Console.WriteLine("LE COMPTE EST EXIST");
                }
                else
                {
                    listComptes.Add(new CompteSurCarnet(n1, n, p, s));
                    Console.WriteLine("un compte carnet ajoute");

                }

            }
            
        }

        public void AjouterCompteSurCheque(int n1, int n2, string t, int n, string p, decimal s)
        {
            foreach (CompteSurCheque compte in listComptes)
            {
                if (compte.GetNumeroCheque() == n1)
                {
                    Console.WriteLine("LE COMPTE EST EXIST");
                }
                else
                {
                    listComptes.Add(new CompteSurCheque(n1, n2, t, n, p, s));
                    Console.WriteLine("un compte cheque ajoute");

                }

            }

        }

        public void DeleteCompte(int numero)
        {
            foreach (Compte compte in listComptes)
            {
                if (compte.GetNumero() == numero)
                {
                    listComptes.Remove(compte);
                    Console.WriteLine("Un compte est bien supprimé");
                }
                else
                {
                    Console.WriteLine("Ce compte est introuvable");
                }
            }
        }

        public void  GetInfoCompte(int numero)
        {
            foreach (Compte compte in listComptes)
            {
                if(compte.GetNumero() == numero)
                {
                    compte.GetInfo();

                }
                else
                {
                    Console.WriteLine("Numero compte est introuvable ");
                }
                

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
