using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Albergo a1 = new Albergo();
            Prenotazione p1= new Prenotazione(new DateTime(2023,12,23), 123, 2023);
            Cliente c1 = new Cliente("Silvia", "Visconti");
            a1.prenotazione = p1;
            a1.cliente= c1;
            //prova di fare ricerce
            int x; //numero
            int a; //anno
            x = int.Parse(Console.ReadLine());
            //fallito
            Console.WriteLine("Prenotazione fatta da {0} {1}, per {2}, con numero {3}",c1.Nome,c1.Cognome,p1.Data, p1.Numero);
            //qui c'è il problema che non si stampa il nome, non capisco perchè
            p1.Servizi.Add(letto);
            //qui volevo provare ad aggiungere un servizio al quale volevo anche mettere un prezzo dopo
            //in base alla logica capisco che non è coretto il metodo però non posso trovare altro modo
            Console.ReadLine();

        }
        
    }
}
