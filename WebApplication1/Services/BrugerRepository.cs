using Microsoft.AspNetCore.Identity;
using WebApplication1.Models;
using static BrugerRepository;


public class BrugerRepository : IBrugerRepository
{
    public List<Bruger> GetAll()
    {
        using BookingContext context = new BookingContext();
        return context.Brugers.ToList();
    }

}

// Her har vi vores Repository til bruger-klassen. Den henter Metoden fra IBrugerRepository og fremskaffer data til liste form. 