using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {

            Gamer gamer = new Gamer() { TC = "17234819780", FirstName = "Elif", LastName = "Kadı", DateOfBirth = new DateTime(1997, 11, 18),GameId=5 };
            Game game = new Game() {GameId=5,GameName="HearthStone" ,GamePrice=100};

            
            AllOfGamesCampaign allOfGamesCampaign = new AllOfGamesCampaign();
            GameManager gameManager = new GameManager();

            GamerManager gamerManager = new GamerManager();
            if (gamerManager.CheckIfRealPerson(gamer))
            {
                gameManager.Sales(game, allOfGamesCampaign);
            }
            else
                throw new Exception("Geçerli kişi değil");
            Console.ReadLine();
            
        }
    }
}
