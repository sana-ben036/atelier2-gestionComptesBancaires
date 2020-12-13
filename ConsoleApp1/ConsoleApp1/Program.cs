using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Banque bq = new Banque();
                void Demarer()
                {
                    Console.WriteLine("Detrminer votre operation : Add, Search, Delete,DetailsCompte, ChekList, Debiter,crediter");
                    string opt = Console.ReadLine();
                    Choix(opt);
                    void Choix( string opt)
                    {
                        if (opt == "Add")
                        {
                            Console.WriteLine("Enter le type de compte : CompteSurCarnet , CompteSurCheque");
                            string type = Console.ReadLine();

                            if(type == "CompteSurCarnet")
                            {
                                Console.WriteLine("Enter les info du compte : NumeroCarnet ,NumeroCompte, NomProprietaire , Solde");
                                int n1 = int.Parse(Console.ReadLine());
                                int n = int.Parse(Console.ReadLine());
                                string p = Console.ReadLine();
                                decimal s = decimal.Parse(Console.ReadLine());
                                bq.AjouterCompteSurCarnet( n1, n, p, s);
                            }
                            else
                            {
                                Console.WriteLine("Enter les info du compte : NumeroCheque,NumeroCarte,DateValidationCarte ,NumeroCompte, NomProprietaire , Solde");
                               
                                int n1 = int.Parse(Console.ReadLine());
                                int n2 = int.Parse(Console.ReadLine());
                                string t = Console.ReadLine();
                                int n = int.Parse(Console.ReadLine());
                                string p = Console.ReadLine();
                                decimal s = decimal.Parse(Console.ReadLine());
                                bq.AjouterCompteSurCheque( n1,  n2, t, n, p, s);
                            }

                        }
                        else if (opt == "Search")
                        {
                            Console.WriteLine("Enter le numero  de compte :");
                            int numero = int.Parse(Console.ReadLine());
                            bq.ChercherCompte(numero);

                        }
                        else if (opt == "Delete")
                        {
                            Console.WriteLine("Enter le numero  de compte :");
                            int numero = int.Parse(Console.ReadLine());
                            bq.DeleteCompte(numero);

                        }
                        else if (opt == "DetailsCompte")
                        {
                            Console.WriteLine("Enter le numero  de compte :");
                            int numero = int.Parse(Console.ReadLine());
                            bq.GetInfoCompte(numero);

                        }
                        else if (opt == "ChekList")
                        {
                            bq.AfficherList();
                        }
                        else if (opt == "Debiter")
                        {
                            Console.WriteLine("Enter le numero  de compte, le montant :");
                            int numero = int.Parse(Console.ReadLine());
                            decimal montant = decimal.Parse(Console.ReadLine());
                            bq.OperationDebiter(numero,montant);
                        }
                        else if (opt == "Crediter")
                        {
                            Console.WriteLine("Enter le numero  de compte , le montant ");
                            int numero = int.Parse(Console.ReadLine());
                            decimal montant = decimal.Parse(Console.ReadLine());
                            bq.OperationCrediter(numero, montant);
                        }
                        Demarer();
                    }






                }
                Demarer();


            }
            catch (Exception ex )
            {
                Console.WriteLine("error : {0}." , ex.Message);
            }
           


        }
    }
}
