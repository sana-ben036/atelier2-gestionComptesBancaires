using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CompteSurCheque : Compte
    {
        private int NumeroCheque;
        private int NumeroCarte;
        private string DateFinValiditeCarte;



        public CompteSurCheque()
        {

        }
        public CompteSurCheque(int n1, int n2, string t, int n, string p, decimal s)
           : base(n, p, s)
        {
            NumeroCheque = n1;
            NumeroCarte = n2;
            DateFinValiditeCarte = t;
        }

        // getters-----------------------
        public int GetNumeroCheque()
        {
            return NumeroCheque;
        }
        public int GetNumeroCarte()
        {
            return NumeroCarte;
        }
        public string GetDateFinValiditeCarte()
        {
            return DateFinValiditeCarte;
        }

        public override string GetInfo()
        {
            string info = "le Numero de compte : " + Numero + "\n"
                + "le nom de proproetaire  : " + NomProprietaire + "\n"
                + "le solde  : " + Solde + " DH \n"
                + "le numero de cheque : " + NumeroCheque + "\n"
                + "le numero de carte : " + NumeroCarte + "\n"
                + "la date de validité de la cart  : " + DateFinValiditeCarte + "  \n";


            return info; 

        }




        //methods ---------------------------
        public override void Debiter(decimal montant)
        {

            if (montant > Solde)
            {
                throw new Exception();

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
