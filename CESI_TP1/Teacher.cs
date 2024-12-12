namespace CESI_TP1;





public abstract class Humain

{



    public abstract void Reagir();


}


public abstract class Teacher : Humain

{



}



public class TeacherYassineEnColere : Teacher

{

    public override void Reagir()

    {

        Console.WriteLine("je suis en colère");

    }

}


public class TeacherYassineCool : Teacher

{

    public override void Reagir()

    {

        Console.WriteLine("je suis Cool");

    }

}



public class TeacherYassineNeutre : Teacher

{

    public override void Reagir()

    {

        Console.WriteLine("je suis Neutre");

    }

}