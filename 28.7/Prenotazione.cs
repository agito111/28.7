using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._7
{
    internal class Prenotazione
    {
        public DateTime Data { get; set; }
        public int Numero { get; set; }
        public int Anno { get; set; }
        public List<Periodo> Periodo { get; set; }
        public List<Informazioni> Servizi { get; set; }
        public Camera Camera { get; set; }
        public Cliente Cliente { get; set; }
       
        public Prenotazione(DateTime data,int numero,int anno) 
        {
            Data = data;
            Numero = numero;
            Anno = anno;
        }

  
       
    }
}
