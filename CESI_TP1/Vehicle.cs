namespace CESI_TP1;

public abstract class Vehicle
{
    protected abstract int GetNumberOfTyres();
}

public class Bicycle : Vehicle
{
    public string Company { get; set; }
    public string Model { get; set; }
    public int NumberOfTyres { get; set; }
    
    public Bicycle(string company, string model)
    {
        Company = company;
        Model = model;
        NumberOfTyres = 2;
    }

    public Bicycle(string company, string model, int numberOfTyres)
    {
        Company = company;
        Model = model;
        NumberOfTyres = numberOfTyres;
    }
    

    protected override int GetNumberOfTyres()
    {
        return NumberOfTyres;
    }
}

public class Car : Vehicle
{
    public string Company { get; set; }
    public string Model { get; set; }
    public int BackTyres { get; set; }
    public int FrontTyres { get; set; }

    public Car(string company, string model)
    {
        Company = company;
        Model = model;
        BackTyres = 2;
        FrontTyres = 2;
    }

    public Car(string company, string model, int backTyres, int frontTyres)
    {
        Company = company;
        Model = model;
        BackTyres = backTyres;
        FrontTyres = frontTyres;
    }

    protected override int GetNumberOfTyres()
    {
        return BackTyres + FrontTyres;
    }
}