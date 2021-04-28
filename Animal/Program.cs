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
                new Visitor("Василий", "Васильев", "+76343346346", new DateTime(2021, 2, 23), new GermanShepherd("Шарик")),
                new Visitor("Владимир", "Владимиров", "+73457983455", new DateTime(2020, 12, 4), new Persian("Пушок")),
                new Visitor("Петр", "Петров", "+79238745736", new DateTime(2021, 4, 1), new AmericanShorthair("Алиса")),
                new Visitor("Николай", "Николаев", "+70983453784", new DateTime(2020, 8, 12), new Вachshund("Бобик"))
            };

            var i = 1;
            foreach (var element in visitor)
            {
                Console.Write($"{i}) ");
                i++;
                Console.WriteLine($"Клиент {element.FirstName} { element.Surname} привел питомца {element.DateTime} по кличке {element.Pet.NickName}.");
                Console.WriteLine($"Cтоимость услуги {calculator.PriceCalculator(element.Pet)}.");
                
            }
        }
    }
}
