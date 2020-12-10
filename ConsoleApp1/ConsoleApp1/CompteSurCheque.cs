using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CompteSurCheque : Compte
    {
        private int NumeroCheque;
        private int NumeroCarte;
        private DateTime DateFinValiditeCarte;



        public CompteSurCheque()
        {

        }
        public CompteSurCheque(int n1, int n2, DateTime t, int n, string p, decimal s)
           : base(n, p, s)
        {
            NumeroCheque = n1;
            NumeroCarte = n2;
            DateFinValiditeCarte = t;
        }
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
