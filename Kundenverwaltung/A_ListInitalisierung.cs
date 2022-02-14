using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Kundenverwaltung
{
    public class A_ListInitalisierung
    {
        public void Example()
        {
            // Lange schreibweiße Objektinitialisierung

            List<Kunde_Hafner> kunden1 = new List<Kunde_Hafner>();

            Kunde_Hafner kunde1 = new Kunde_Hafner();
            kunde1.Id = 1;
            kunde1.Name = "Stefan";
            kunden1.Add(kunde1);

            Kunde_Hafner kunde2 = new Kunde_Hafner();
            kunde2.Id = 2;
            kunde2.Name = "Josf";
            kunden1.Add(kunde2);

            Kunde_Hafner kunde3 = new Kunde_Hafner();
            kunde3.Id = 3;
            kunde3.Name = "Julia";
            kunden1.Add(kunde3);

            Kunde_Hafner kunde4 = new Kunde_Hafner();
            kunde4.Id = 4;
            kunde4.Name = "Uwe";
            kunden1.Add(kunde4);

            Kunde_Hafner kunde5 = new Kunde_Hafner();
            kunde5.Id = 5;
            kunde5.Name = "Rudolf";
            kunden1.Add(kunde5);

            // Kurzschreibweiße Objektinitialisierung
            List<Kunde_Hafner> kunden2 = new List<Kunde_Hafner>()
            {
                new Kunde_Hafner(){ Id = 1, Name = "Stefan"},
                new Kunde_Hafner(){ Id = 2, Name = "Josf"},
                new Kunde_Hafner(){ Id = 3, Name = "Julia"},
                new Kunde_Hafner(){ Id = 4, Name = "Uwe"},
                new Kunde_Hafner(){ Id = 5, Name = "Rudolf"},
            };
        }
    }
}
