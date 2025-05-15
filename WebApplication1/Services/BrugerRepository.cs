using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


public abstract class BrugerRepository : IBrugerRepository
{
    

    public List<Bruger> GetAll()
    {
        using BookingContext context = new BookingContext();
        return context.Brugers.ToList();
    }


    public virtual int Create(Bruger b)
    {


        using DbContext context = new BookingContext();

        int id = NextId();
        b.Id = id;

        context.Set<Bruger>().Add(b);
        context.SaveChanges();

        return b.Id;
    }
    private int NextId()
    {
        return GetAll().Select(b => b.Id).DefaultIfEmpty(0).Max() + 1;
    }



}



// Her har vi vores Repository til bruger-klassen. Den henter Metoden fra IBrugerRepository og fremskaffer data til liste form. 