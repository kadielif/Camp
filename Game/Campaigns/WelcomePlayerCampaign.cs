using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class WelcomePlayerCampaign : ICampaignManager
    {
        public void CampaignAdd()
        {
            Console.WriteLine("Hoşgeldin kampanyası eklendi");
        }

        public void CampaignRemove()
        {
            Console.WriteLine("Hoşgeldin kampanyası kaldırıldı");
        }

        public void CampaignUpdate()
        {
            Console.WriteLine("Hoşgeldin kampanyası güncellendi");
        }
    }
}
