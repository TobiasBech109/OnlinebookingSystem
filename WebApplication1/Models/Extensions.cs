using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OnlinebookingSystem.Models
{
    public partial class Bruger : IHarId
    {
        public bool IsAdmin() { return Rolle == "admin"; }
        public override string ToString()
        {
            return $"[Kunde {Id}] {Navn} (tlf: {Telefon}), Email er {Email} og deres givende Rolle {Rolle}";
        }

        public static Bruger Construct(string navn, int telefon, string email)
        {
            return new Bruger { Navn = navn, Telefon = telefon, Email = email };
        }
    }

    public partial class Lokale : IHarId
    {

        public override string ToString()
        {
            return $"[Lokale {Id}] Smartboard er {Smartboard}, og lokalets størrelse er til {Størrelse} grupper, og der kan være {Kapacitiet}";
        }

        public static Lokale Construct(int id, bool smartboard, int størrelse, int kapacitiet)
        {
            return new Lokale { Id = id, Smartboard = smartboard, Størrelse = størrelse, Kapacitet = kapacitet};
        }
    }

    public partial class Booking : IHarId
    {
        public override string ToString()
        {
            return $"[Booking {Id}] {Bruger.Navn} har booket {Lokale.Id} fra {Starttid}, til {Sluttid} og de har valgt {smartboard} fra {starttid} til {sluttid}";
        }

        public static Booking Construct(string brugerNavn, int lokaleId, DateTime starttid, DateTime sluttid, bool smartboard)
        {
            return new Booking { BrugerNavn = brugerNavn, LokaleId = lokaleId, Starttid = starttid, Sluttid = sluttid, Smartboard = smartboard};
        }
    }

   
}
