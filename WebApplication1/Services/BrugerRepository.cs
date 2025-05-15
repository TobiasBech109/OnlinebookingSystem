using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


public abstract class BrugerRepository<T, TContext> : IBrugerRepository<T>
    where T : class
    where TContext : DbContext, new()
    
public class BrugerRepository : IBrugerRepository
    where T : class
    where TContext : DbContext, new()
{
    public List<Bruger> GetAll()
    {
        using BookingContext context = new BookingContext();
        return context.Brugers.ToList();
    }


    public virtual int Create(T t)
    {
        using DbContext context = new TContext();

        int id = NextId();
        t.Id = id;

        context.Set<T>().Add(t);
        context.SaveChanges();

        return t.Id;
    }



}



// Her har vi vores Repository til bruger-klassen. Den henter Metoden fra IBrugerRepository og fremskaffer data til liste form. 