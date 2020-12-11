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
            if (listComptes.Count > 0)
            {
                foreach (Compte compte in listComptes)
                {
                    if (compte.GetNumero() == numero)
                    {
                        int indice = listComptes.IndexOf(compte);
                        Console.WriteLine( indice ); 

                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }

                }
            }
            else
            {
                Console.WriteLine(-1);
            }

            
        }


        public void AjouterCompteSurCarnet(int n1, int n, string p, decimal s)
        {

            if (listComptes.Count > 0)
            {
                foreach (Compte compte in listComptes)
                {
                    if (compte.GetNumero() == n)
                    {
                        Console.WriteLine("Ce compte est déja enregisté ");
                    }
                    else
                    {
                        listComptes.Add(new CompteSurCarnet(n1, n, p, s));

                    }

                }
            }
            else
            {
                listComptes.Add(new CompteSurCarnet(n1, n, p, s));
            }


        }

        public void AjouterCompteSurCheque(int n1, int n2, string t, int n, string p, decimal s)
        {
            
            if (listComptes.Count > 0 )
            {
                foreach (Compte compte in listComptes)
                {
                    if (compte.GetNumero() == n)
                    {
                        Console.WriteLine("Ce compte est déja enregisté");
                    }
                    else
                    {
                        listComptes.Add(new CompteSurCheque(n1, n2, t, n, p, s));

                    }

                }
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
                listComptes.RemoveAll(x => x.GetNumero() == numero);
            }
            else
            {
                Console.WriteLine("La list est vide");
            }
        }

        public void  GetInfoCompte(int numero)
        {
            foreach (Compte compte in listComptes)
            {
                if(compte.GetNumero() == numero)
                {
                    Console.WriteLine(compte.GetInfo()); 

                }
                else
                {
                    Console.WriteLine("Numero de compte est introuvable ");
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
