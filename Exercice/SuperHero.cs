using System;
using System.Collections.Generic;
using System.Text;

namespace CivilWar
{
    class SuperHero
    {
        private string nom;
        private string superPouvoir;

        protected SuperHero()
        {            
        }

        public string GetNom()
        {
            return nom;
        }

        public string GetPouvoir()
        {
            return superPouvoir;
        }
    }
}
