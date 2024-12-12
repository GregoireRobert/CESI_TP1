
using CESI_TP1;

Enumerable.Range(1, count: 100).ToList().ForEach(_ =>

{

    int temp = new Random().Next(0, 3);


    Humain c = temp switch

    {

        0 => new TeacherYassineCool(),

        1 => new TeacherYassineEnColere(),

        _ => new TeacherYassineNeutre()


    };

    c.Reagir();

});

