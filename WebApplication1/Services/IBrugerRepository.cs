
public interface IBrugerRepository
{
    public interface IBrugerRepository<T> where T : Bruger;
    List<Bruger> GetAll();

}

// Vi er startet ud med at lave denne klasse.
// Vi bruger den til at udskrevet en liste af brugere igennem getAll metoden, og tager den i brug i VisAlleBrugere. 

