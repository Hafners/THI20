using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Kundenverwaltung
{
    internal class A_Linq
    {
        public void Example()
        {
            List<Kunde_Hafner> kunden2 = new List<Kunde_Hafner>()
            {
                new Kunde_Hafner(){ Id = 1, Name = "Stefan"},
                new Kunde_Hafner(){ Id = 2, Name = "Josf"},
                new Kunde_Hafner(){ Id = 3, Name = "Julia"},
                new Kunde_Hafner(){ Id = 4, Name = "Uwe"},
                new Kunde_Hafner(){ Id = 5, Name = "Rudolf"},
            };

            // Linq

            // hier werden die Daten zurückgegeben die der Bedingung entsprechen
            List<Kunde_Hafner> matchedKunden = kunden2.Where(kunde => kunde.Name.Contains('u')).ToList();

            // existiert mindstens ein Kunde mit einem U im Namen
            bool exist = kunden2.Any(kunde => kunde.Name.Contains('u'));

            // gibt das erste Element mit der ID 5 zurück -> ist kein Element mit der ID 5 enthalten wird eine Exception geschmissen!
            Kunde_Hafner kunde1 = kunden2.First(x => x.Id == 5);

            // gibt das erste Element mit der ID 5 zurück -> ist kein Element mit der ID 5 enthalten wird null zurückgegeben!
            Kunde_Hafner kunde2 = kunden2.FirstOrDefault(x => x.Id == 5);

            // gibt das erste Element mit der ID 5 zurück -> ist kein Element mit der ID 5 enthalten oder existieren mehr als ein Objekt mit der ID 5 wird eine Exception geschmissen!
            Kunde_Hafner kunde3 = kunden2.Single(x => x.Id == 5);

            // gibt das erste Element mit der ID 5 zurück -> sind mehr Elemente mit der ID 5 enthalten wird eine Exception geschmissen, ist kein Objekt vorhanden wird null zurückgegeben!
            Kunde_Hafner kunde4 = kunden2.SingleOrDefault(x => x.Id == 5);

            // Daten gruppieren anhand der UserId -> anschließendes summieren!
            kunden2.GroupBy(x => x.UserId);
        }
    }
}
