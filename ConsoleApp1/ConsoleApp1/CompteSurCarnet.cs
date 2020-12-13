using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CompteSurCarnet : Compte
    {
        private int NumeroCarnet;


        public CompteSurCarnet()
        {

        }
        public CompteSurCarnet(int n1, int n, string p, decimal s) : base (n,p,s)
        {
            NumeroCarnet = n1;
        }

        // getters--------------------------------------------
        public int GetNumeroCarnet()
        {
            return NumeroCarnet;
        }

        public override string GetInfo()
        {
            string info = "le Numero de compte : " + Numero + "\n"
                + "le nom de proproetaire  : " + NomProprietaire + "\n"
                + "le solde  : " + Solde + " DH \n"
                + "le numero de cheque : " + NumeroCarnet + "\n";
               


            return info;

        }


        public override void Debiter(decimal montant)
        {
            if (montant > Solde)
            {
                throw new Exception("Solde insuffisant");

            }
            else if (montant > 10000)
            {
                throw new Exception("Plafond dépassé");
            }
            else
            {
                Solde -= montant;
            }
        }
        public override void Crediter(decimal montant)
        {
            Solde += montant;
        }







    }

   
}
