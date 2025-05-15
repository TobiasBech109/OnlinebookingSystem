
public interface IBrugerRepository
{
    List<Bruger> GetAll();
    int Create(Bruger b);

}

// Vi er startet ud med at lave denne klasse.
// Vi bruger den til at udskrevet en liste af brugere igennem getAll metoden, og tager den i brug i VisAlleBrugere. 

