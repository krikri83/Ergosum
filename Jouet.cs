using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ergosum
{
    public class Jouet
    {
        private int numero;
        private string libelle;
        private Categorie laCategorie;
        private TrancheAge laTranche;
        /// <summary>
        /// Instancie un objet Jouet et l’ajoute dans la collection des jouets de sa catégorie
        /// </summary>
        public Jouet(int numero, string libelle, Categorie categorie, TrancheAge latranche)
        {
            this.numero = numero;
            this.libelle = libelle;
            this.laCategorie = categorie;
            this.laTranche = latranche;
			this.laCategorie.ajouterJouet(this);

        }
        public int getNumero() { return this.numero; }
        public string getLibelle() { return this.libelle; }
        public Categorie getLaCategorie() { return this.laCategorie; }
        public TrancheAge getLaTranche() { return this.laTranche; }
        /// <summary>
        /// Retourne vrai si lesJouet jouet convient à l’âge passé en paramètre.
        /// </summary>
        public bool convient(int age)
        {
			bool ok = false;
			if (this.laTranche.getAgeMaxi() < age && this.laTranche.getAgeMin() > age)
				ok = true;
			return ok;
        }
       /// <summary>
        ///  Retourne une chaîne contenant : libellé du jouet, libellé de sa catégorie, 
        /// les âges minimum et maximum de la tranche d’âge lui correspondant. 
        /// Les informations sont séparées par des points-virgules.
        /// </summary>
        public override string ToString()
        {
			string s = "Le Jouet: " + this.libelle + "; Son Catégorie: " + this.laCategorie + 
				"; Son age minimum: " + this.laTranche.getAgeMin() + "; Son age maximum" + this.laTranche.getAgeMin();
                        
            return s;
        }
		//3.3
		/*Un test unitaire testant la construction d’un jeu donne le résultat suivant ; 
		 * expliquer la raison de l’échec ; quelle modification faut-il apporter dans 
		 * le constructeur de jouet ?*/
		 /*Reponse: Le Jouet n'est pas dans le categorie. Il faut ajouter le jouet dans laCategorie par la methode c.ajouter(j).*/
	}
}
