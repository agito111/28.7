using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._7
{
    internal class Cliente
    {
        public int codice { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string citta { get; set; }
        public string provincia { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string cellulare { get; set; }

        public Cliente(string nome,string cognome ) 
        {
            nome = Nome;
            cognome = Cognome;
        }
    }
}
