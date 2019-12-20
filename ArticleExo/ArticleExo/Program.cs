using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleExo
{
    public class Article
    {

        string reference;
        string designation;
        float prixHT;
        float tauxTVA;

        public string Reference { get => reference; set => reference = value; }
        public string Designation { get => designation; set => designation = value; }
        public float PrixHT { get => prixHT; set => prixHT = value; }
        public float TauxTVA { get => tauxTVA; set => tauxTVA = value; }


        public Article(string areference, string adesign,float aprixht, float atauxtva) {

            this.reference = areference;
            this.designation = adesign;
            this.prixHT = aprixht;
            this.tauxTVA = atauxtva;

      

        }
        // constructeur de recopie
        public Article ( Article unarticle)
        {
            this.reference = unarticle.reference;
            this.designation = unarticle.designation;
            this.prixHT = unarticle.prixHT;
            this.tauxTVA = unarticle.tauxTVA;
        }

       public float CalculerTTC(Article a1)
        {
            float total;
            total = a1.prixHT + (a1.prixHT * a1.tauxTVA / 100);
            return total;
        }

        public void AfficheArticle(Article a1)
        {
            Console.WriteLine("reference : " + a1.reference + " designation : " + a1.designation + " prixHT : "+ a1.prixHT + " TVA : " + a1.tauxTVA);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Article a1 = new Article("465","livre",15,19);
           float Total= a1.CalculerTTC(a1);
            Console.WriteLine("Prix TTC : " + Total);
            a1.AfficheArticle(a1);
            Console.ReadLine();


        }
    }
}
