using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class GamerManager:IGamerCheckedService
    {
        public void Register (Gamer gamer){
            Console.WriteLine("Kayit tamamlandi");
        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayit Güncellendi");
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.Id+" nolu oyuncu sistemden silindi");
        }

        public bool CheckIfRealPerson(Gamer gamer)
        {
            MernisServiceAdapter mernisServiceAdapter = new MernisServiceAdapter();
            return mernisServiceAdapter.CheckIfRealPerson(gamer);
        }
    }
}
