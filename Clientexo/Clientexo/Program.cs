using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientexo
{
    class Program
    {

        public class Client
        {

            string CNI;
            string nom;
            string prenom;
            string tel;

            public string Nom { get => nom; set => nom = value; }
            public string Prenom { get => prenom; set => prenom = value; }
            public string Tel { get => tel; set => tel = value; }
            public string CNI1 { get => CNI; set => CNI = value; }

            public Client(string acni1, string anom, string aprenom, string atel)
            {
                this.CNI = acni1;
                this.nom = anom;
                this.prenom = aprenom;
                this.tel = atel;

            }

            public Client(string acni1, string anom, string aprenom)
            {
                this.CNI = acni1;
                this.nom = anom;
                this.prenom = aprenom;

            }

            public void Afficher(Client c1)
            {
                Console.WriteLine(" CNI :" + c1.CNI + " Nom : " + c1.nom + " Prenom : " + c1.prenom + " Tel : " + c1.tel);
            }

            

        }

        public class Compte
        {


            float solde;
            string code;
            string proprietaire;


            public float Solde { get => solde; }
            public string Code { get => code; }
            public string Proprietaire { get => proprietaire; set => proprietaire = value; }


            public Compte (float asolde, string acode, string aproprio)
            {

                this.code = acode;
                this.solde = asolde;
                this.proprietaire = aproprio;
         


            }

            public void Crediter(Compte c1,float montant)
            {
                c1.solde = c1.solde + montant;
                
            }
            public void Debiter(Compte c1, float montant)
            {
                c1.solde = c1.solde - montant;

            }

            public void Virement(Compte ajoute, Compte debiter, float montant)
            {
                ajoute.solde =ajoute.solde + montant;
                debiter.solde = debiter.solde - montant;

            }

            public void Nbcompte(List<Compte> comptes)
            {

                Console.WriteLine(" nombre de comptes : " + comptes.Count());
            }


        }

            static void Main(string[] args)
            {
            Random rand = new Random();
            int randNum = rand.Next(1, 500000);

            Client c1 = new Client(randNum.ToString(), "Manenc", "Florent");
            Client c2 = new Client(randNum.ToString(), "Lopez", "Loriane");


            c1.Afficher(c1);

            var listcompte = new List<Compte>();
            int compteur = 1;
            Compte compte1 = new Compte(50000, randNum.ToString(), c1.Nom);
            listcompte.Add(compte1);
            Compte compte2 = new Compte(20000, randNum.ToString(), c2.Nom);
            listcompte.Add(compte2);


            Console.WriteLine(" solde du compte :" + compte1.Solde + " code : " + compte1.Code + " proriétaire : " + compte1.Proprietaire);
            compte1.Crediter(compte1, 4000);
            Console.WriteLine(" solde du compte :" + compte1.Solde + " code : " + compte1.Code + " proriétaire : " + compte1.Proprietaire);
            compte1.Debiter(compte1, 4000);
            Console.WriteLine(" solde du compte :" + compte1.Solde + " code : " + compte1.Code + " proriétaire : " + compte1.Proprietaire);
            compte1.Virement(compte1,compte2, 4000);
            Console.WriteLine(" solde du compte :" + compte1.Solde + " code : " + compte1.Code + " proriétaire : " + compte1.Proprietaire);
            Console.WriteLine(" solde du compte :" + compte2.Solde + " code : " + compte2.Code + " proriétaire : " + compte2.Proprietaire);

            compte1.Nbcompte(listcompte);

            Console.ReadLine();
            }
        
    }
}
