namespace CESI_TP1;

public class Aliment
{
    protected DateTime DateDePeremption { get; set; }

    public bool IsPerime()
    {
        return DateDePeremption < DateTime.Now;
    }
}

public class Viande : Aliment
{
    private String Type { get; set; }
}

public class Pain : Aliment
{
    public String Farine { get; set; }
}

public class Fruit : Aliment
{
    
}

public class Pomme: Fruit {}
