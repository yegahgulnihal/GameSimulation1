using System;

namespace GameSimulation1
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager()); //Doğrulama servisini belirtmek gerekir.
            gamerManager.Add(new Gamer {
                Id = 1,
                BirthDate = 1997,
                FirstName = "Yegah",
                LastName = "Değirmenci" });

            OrderManager order1 = new OrderManager();
            order1.AddOrder(new Orders { 
                GameCompany="Nintendo",
                GameName="The Legend of Zelda",
                GamePrice=159
                });

        }
    }
}
