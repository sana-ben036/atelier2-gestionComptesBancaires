using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CompteSurCarnet : Compte
    {
        private int NumeroCanret;


        public CompteSurCarnet()
        {

        }
        public CompteSurCarnet(int n1, int n, string p, decimal s) : base (n,p,s)
        {
            NumeroCanret = n1;
        }
        public override void Debiter(decimal montant)
        {
            if (montant > Solde)
            {
                throw new Exception();

            }
            else if (montant > 10000)
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
