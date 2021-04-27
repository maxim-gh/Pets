using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator= new Calculator();
            var visitor = new Visitor[]
            {
                new Visitor("Василий", "Васильев", "+76343346346", new DateTime(2021, 2, 23), new Pet ("Шарик", "Овчарка", PetType.Dog, 4)),
                new Visitor("Владимир", "Владимиров", "+73457983455", new DateTime(2020, 12, 4), new Pet ("Пушок", "Манчкин", PetType.Cat, 2)),
                new Visitor("Петр", "Петров", "+79238745736", new DateTime(2021, 4, 1), new Pet ("Алиса", "Британская короткошорстная", PetType.Cat, 3)),
                new Visitor("Николай", "Николаев", "+70983453784", new DateTime(2020, 8, 12), new Pet ("Бобик", "Такса", PetType.Dog, 1))
            };

            var i = 1;
            foreach (var element in visitor)
            {
                Console.Write($"{i}) ");
                i++;
                Console.Write($"Клиент {element.FirstName} { element.Surname} привел питомца {element.DateTime} ");
                Console.WriteLine($"по кличке {element.Pet.NickName}, порода {element.Pet.Breed}, вид питомца {element.Pet.PetType}.");
                Console.WriteLine($"Cтоимость услуги {calculator.PriceCalculator(element.Pet.PetType,element.Pet.DiffcultyFactor)}.");
                
            }
        }
    }
}
