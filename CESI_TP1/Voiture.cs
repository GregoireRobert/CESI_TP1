namespace CESI_TP1;

public class Voiture
{
    public int Vitesse { get; set; }
    public void Incrementer()
    {
        Incrementer(++Vitesse);
    }

    public void Incrementer(int vitesse)
    {
        Vitesse = vitesse;
        // for (int i = 0; i < qte; i++) Incrementer();
    }

    public void Decrementer()
    {
        Decrementer(--Vitesse);
    }
    
    public void Decrementer(int vitesse)
    {
        Vitesse = vitesse;
    }
    public void Afficher()
    {
        Console.WriteLine("La voiture est à la vitesse : " + Vitesse);
    }
    public Voiture()
    {
        Vitesse = 0;
    }

    public Voiture(int vitesse)
    {
        Vitesse = vitesse;
    }
}