using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator= new Calculator();
            var pet = new Pet[]
            {
                new Pet("Шарик", "Овчарка", PetType.Dog, 4),
                new Pet("Пушок", "Манчкин", PetType.Cat, 2)
            };
            var visitor = new Visitor[]
            {
                new Visitor("Антон", "Пружинин", "+79195992945"),
                new Visitor("Леонид", "Воронцов", "+73457983455")
            };

            foreach(var element in pet)
            {
                Console.Write($"Пришел питомец по кличке {element.NickName}, порода {element.Breed}, вид питомца {element.PetType}, ");
                Console.WriteLine($"cтоимость услуги {calculator.PriceCalculator(element.PetType,element.DiffcultyFactor)}.");
            }
        }
    }
}
