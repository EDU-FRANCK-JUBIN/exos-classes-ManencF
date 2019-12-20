using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExo
{

    public class CompteBancaire
    {

        string titulaire;
        float solde;
        string devise;

        int nbcomptes;

        public string Titulaire { get => titulaire; set => titulaire = value; }
        public float Solde { get => solde; set => solde = value; }
        public string Devise { get => devise; set => devise = value; }


        public CompteBancaire(string ititulaire, float isolde, string idevise)
        {
            this.titulaire = ititulaire;
            this.solde = isolde;
            this.devise = idevise;
        }

        public void Crediter(float soldea)
        {
            Solde = Solde + soldea;

        }

        public void Debiter(float soldea)
        {

            Solde = Solde - soldea;
        }

        public void Decrire(string a, float e, string b)
        {

            Console.WriteLine(" titulaire : " + a + " solde du compte : " + b + " devise : " + e);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire c1 = new CompteBancaire("Manenc",50000,"EUR");
            c1.Decrire(c1.Titulaire,c1.Solde,c1.Devise);
            c1.Crediter(500);
            c1.Decrire(c1.Titulaire, c1.Solde, c1.Devise);
            c1.Debiter(50);
            c1.Decrire(c1.Titulaire, c1.Solde, c1.Devise);

            Console.ReadLine();
        }
    }
}
