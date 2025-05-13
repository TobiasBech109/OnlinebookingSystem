using WebApplication1.Models;


public class BrugerRepository : IBrugerRepository
{
    public List<Bruger> GetAll()
    {
       using BookingContext context = new BookingContext();
        return context.Brugers.ToList();
    }
}

// Her har vi vores Repository til bruger-klassen. Den henter Metoden fra IBrugerRepository og fremskaffer data til liste form. 