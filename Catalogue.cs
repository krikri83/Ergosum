using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ergosum
{
    public class Catalogue
    {
        private int annee;
        /// <summary>
        /// Contient pour chaque jouet du catalogue : 
        ///- en clé, l’objet de la classe lesJouet
        /// - en valeur, la quantité de ce jouet distribuée pour ce catalogue
        /// </summary>
        private Dictionary<Jouet, int> lesJouets;
        public Catalogue(int annee)
        {
            this.annee = annee;
            this.lesJouets = new Dictionary<Jouet, int>();
        }
        public Dictionary<Jouet, int> getLesJouets() { return this.lesJouets; }
        /// <summary>
        /// Ajoute au dictionnaire un jouet et sa quantité
        /// retourne vrai si l'objet n'était pas déjà présent, 
        /// faux dans le cas contraire
        /// </summary>
        public bool ajouterJouet(Jouet jouet, int quantite)
        {
			bool ok = false;
			
			if(!this.lesJouets.ContainsKey(jouet))
			{
				this.lesJouets.Add(jouet, quantite);
				ok = true;
			}
			
            return ok;
             
        }
        /// <summary>
        ///  Retourne la quantité totale de jouets distribués pour ce catalogue.
        /// </summary>
        public int quantiteDistribuee()
        {
			var qte = 0;
			var lesKeys = this.lesJouets.Keys;
			foreach(Jouet j in lesKeys)
			{
				qte += this.lesJouets[j];
			}
            return qte;
        }
        /// <summary>
        /// Retourne un dictionnaire contenant pour chaque catégorie de ce catalogue :
        /// - en clé, l’objet de la classe Catégorie
        /// - en valeur, la quantité de jouets distribués pour cette catégorie.
        /// </summary>
        public Dictionary<Categorie, int> statCategorie()
        {
			Dictionary<Categorie, int> dico = new Dictionary<Categorie, int>();
			var lesCles = this.lesJouets.Keys;
			foreach(Jouet i in lesCles)
			{
				if (dico.ContainsKey(i.getLaCategorie()))
					dico[i.getLaCategorie()] += this.lesJouets[i];
					//si la categorie exist dans le dico, on comul son contenu
				else
					dico.Add(i.getLaCategorie(), this.lesJouets[i]);
					//et si la categorie n'exist pas, on l'ajouter.
			}
            return dico;
        }
    }
}
