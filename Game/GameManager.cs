using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class GameManager
    {
        public void Sales(Game game,ICampaignManager campaignManager)
        {   
            campaignManager.CampaignAdd();
            Console.WriteLine(game.GameName+" Oyunu Satıldı");
        }
    }
}
