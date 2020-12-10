using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Banque
    {
        // les champs
        private List<Compte> listComptes;

        public Banque()
        {
            listComptes = new List<Compte>(); // declaration d'une list 

        }

        public int ChercherCompte(int numero)
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
                    return -1;
                }

            }

        }


        public void AjouterCompteSurCarnet(int n1, int n, string p, decimal s)
        {
            foreach(Compte compte in listComptes)
            {
                if(compte.GetNumero() == n)
                {
                    Console.WriteLine("LE COMPTE EST EXIST");
                }
                else
                {
                    listComptes.Add(new CompteSurCarnet(n1, n, p, s));

                }

            }
            
        }

        public void AjouterCompteSurCheque(int n1, int n2, string t, int n, string p, decimal s)
        {
            foreach (Compte compte in listComptes)
            {
                if (compte.GetNumero() == n)
                {
                    Console.WriteLine("LE COMPTE EST EXIST");
                }
                else
                {
                    listComptes.Add(new CompteSurCheque(n1, n2, t, n, p, s));

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
            }
        }

        public string  GetInfoCompte(int numero)
        {
            foreach (Compte compte in listComptes)
            {
                if(compte.GetNumero() == numero)
                {
                    string info = "le Numero de compte : " + compte.GetNumero() + "\n"
                + "le nom de proproetaire  : " + compte.GetNomProprietaire() + "\n"
                + "le solde actuel  : " + compte.GetSolde() + " DH \n";

                    return info;

                }
                else
                {
                    Console.WriteLine("CE COMPTE EST INTROUVABLE");

                }

            }
        }

        public void AfficherList()
        {
            foreach (Compte compte in listComptes)
            {
                compte.GetInfo();
            }
        }















    }
}
