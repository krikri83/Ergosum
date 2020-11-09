using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ergosum
{
    public class Categorie
    {
        private int code;
        private string libelle;
        private List<Jouet> lesJouets;
        public Categorie(int code, string libelle)
        {
            this.code = code;
            this.libelle = libelle;
            this.lesJouets = new List<Jouet>();
        }
        public int getCode() {return this.code; }
        public string getLibelle() { return this.libelle; }
        public List<Jouet> getLesJouets() { return this.lesJouets; }
        public void ajouterJouet(Jouet jouet)
        {
            this.lesJouets.Add(jouet);
        }
    }
}
