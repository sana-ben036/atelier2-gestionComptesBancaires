using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Compte
    {
       protected int Numero;
       protected string NomProprietaire;
       protected decimal Solde;

        public Compte()
        {

        }
        public Compte( int n, string p, decimal s )
        {
            Numero=n;
            NomProprietaire=p;
            Solde=s;

        }

        // getters ----------------------------------
        public int GetNumero()
        {
            return Numero;
        }
        public string GetNomProprietaire()
        {
            return NomProprietaire;
        }

        public decimal GetSolde()
        {
            return Solde;
        }


        // setters-------------------------

        public void SetSolde(decimal value )
        {
            Solde= value;
        }


        // abstract method 

        public abstract void Debiter(decimal montant);
        public abstract void Crediter(decimal montant);
        public abstract string GetInfo();




    }

}
