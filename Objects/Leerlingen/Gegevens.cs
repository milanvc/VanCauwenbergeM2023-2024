using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leerlingen
{
    internal class Gegevens
    {
        private string naam;
        private string voornaam;
        private string klas;

        public string Naam { get { return naam; } set {  naam = value; } }
        public string Voornaam { get {  return voornaam; } set {  voornaam = value; } }
        public string Klas { get {  return klas; } set {  klas = value; } }

        public Gegevens(string naam, string voornaam, string klas)
        { 
            this.naam = naam;
            this.voornaam = voornaam;
            this.klas = klas;
        }
    }
}
