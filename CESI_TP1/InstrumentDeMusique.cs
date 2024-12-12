namespace CESI_TP1;

public abstract class InstrumentDeMusique
{
    public string Timbre  { get; set; }
    public abstract void Accorder();
}
public class Voix : InstrumentDeMusique
{
    public string Classement { get; set; } // Soprano, Tenor, Baryton, etc.

    public override void Accorder()
    {
        Console.WriteLine("Se chauffe la voix.");
    }
    public void Chanter(string paroles)
    {
        Console.WriteLine("Chanter: " + paroles);
    }
}

public abstract class InstrumentAVent : InstrumentDeMusique
{
    public string Fabricant { get; set; }
    

    
    public InstrumentAVent(string fabricant)
    {
        Fabricant = fabricant;
    }
    public void NettoyerCorps()
    {
        Console.WriteLine("On nettoie le corps.");
    }
}

public abstract class InstrumentACorde : InstrumentDeMusique
{
    public string Fabricant { get; set; }
    public int NombreCordes { get; set; }
    public InstrumentACorde(string fabricant, int nombreCordes)
    {
        Fabricant = fabricant;
        NombreCordes = nombreCordes;
    }


    public void ChangerCordes()
    {
        Console.WriteLine("Les cordes changent.");
    }
}

public class Trompette : InstrumentAVent
{
    public Trompette(string fabricant): base(fabricant)
    {
        Timbre = "Pouet";
    }
    
    public override void Accorder()
    {
        Console.WriteLine("On bouge les coulisses.");
    }
}

public class Saxophone : InstrumentAVent
{
    public Saxophone(string fabricant) : base(fabricant)
    {
        Timbre = "Tvuuuuu";
    }
    public override void Accorder()
    {
        Console.WriteLine("On déplace les anches.");
    }
}

public class Violon : InstrumentACorde
{
    public Violon(string fabricant, int nombreCordes) : base(fabricant, nombreCordes)
    {
        Timbre = "Viiii";
    }
    
    public override void Accorder()
    {
        Console.WriteLine("On tourne les cadrans.");
    }
}




