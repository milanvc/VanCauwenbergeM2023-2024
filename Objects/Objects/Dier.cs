using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    internal class Dier
    {
        private string soort;
        private string naam;
        private int aantalpoten;
        private int leeftijd;
    
        public string Soort {  get { return soort; } set {  soort = value; } }
        public string Naam {  get { return naam; } set { naam = value; } }
        public int Aantalpoten { get {  return aantalpoten; } set {  aantalpoten = value; } }
        public int Leeftijd { get {  return leeftijd; } set {  leeftijd = value; } }

        public Dier(string soort, string naam, int aantalpoten, int leeftijd) 
        {
            this.soort = soort;
            this.naam = naam;
            this.aantalpoten = aantalpoten;
            this.leeftijd = leeftijd;
        }
        public int Leeftijdplus(int leeftijdplus)
        {
            leeftijdplus = leeftijd += 1;

            return leeftijdplus;
        }
    }
}
