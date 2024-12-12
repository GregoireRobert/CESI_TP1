namespace VeloCarRentals;

public abstract class Vehicle
{
    public string LicensePlate { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }

    public abstract string GetInfo();
    
}

public class Car : Vehicle, IRentable
{
    public int NumberOfSeats { get; set; }

    public Car(string licensePlate, string brand, string model, int numberOfSeats)
    {
        LicensePlate = licensePlate;
        Brand = brand;
        Model = model;
        NumberOfSeats = numberOfSeats;
    }

    public override string GetInfo()
    {
        return $"Marque: {Brand}, Modèle: {Model}, Plaque d'immatriculation: {LicensePlate}, Nombre de place: {NumberOfSeats}";
    }
    public decimal CalculateRentalPrice(int days)
    {
        return days * 50;
    }
    
}

public class Motorcycle : Vehicle, IRentable
{
    public bool HasSidecar { get; set; }

    public Motorcycle(string licensePlate, string brand, string model, bool hasSidecar)
    {
        LicensePlate = licensePlate;
        Brand = brand;
        Model = model;
        HasSidecar = hasSidecar;
    }

    public override string GetInfo()
    {
        string sidecarString = HasSidecar ? "Avec" : "Sans";
        return $"Marque: {Brand}, Modèle: {Model}, Plaque d'immatriculation: {LicensePlate}, Side-car: {sidecarString}";
    }

    public decimal CalculateRentalPrice(int days)
    {
        return days > 5 ? 30 * days * 0.9m : 30 * days;
    }
}

public interface IRentable
{
    public decimal CalculateRentalPrice(int days);
}