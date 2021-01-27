using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class AllOfGamesCampaign:ICampaignManager
    {
        public void CampaignAdd()
        {
            Console.WriteLine("Tüm oyunlar aylık 100tl kampanyası eklendi");
        }

        public void CampaignRemove()
        {
            Console.WriteLine("Tüm oyunlar aylık 100tl kampanyası kaldırıldı");
        }

        public void CampaignUpdate()
        {
            Console.WriteLine("Tüm oyunlar aylık 100tl kampanyası güncellendi");
        }
    }
}
