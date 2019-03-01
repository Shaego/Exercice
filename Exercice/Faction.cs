using System;
using System.Collections.Generic;
using System.Text;

namespace CivilWar
{
    class Faction
    {
        private List<SuperHero> membres;
        private string nom;

        public Faction(string nom)
        {
            membres = new List<SuperHero>();
            this.nom = nom;
        }

        public void AjouterMembre(SuperHero hero)
        {
            membres.Add(hero);
        }
        public void SupprimeMembre(string nomHero)
        {
            membres.Remove();
        }
        
        public bool GetInfoMembres()
        {
            bool info = true;

            foreach (SuperHero membres in membres)
            {
                Console.WriteLine(membres.GetNom());
                Console.WriteLine(membres.GetPouvoir());
            }

            return info;
        }
    }
}
