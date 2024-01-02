using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fırın
{
    internal class olustur
    {

        public List<kayıtlar> ekmek = new List<kayıtlar>();

        public void yeniKayit(kayıtlar urun)
        {
            ekmek.Add(urun);
        }
        public void kayitGüncelleme(int secilen, kayıtlar guncelveri)
        {
            ekmek[secilen] = guncelveri;
        }
        public void kayitSil(int secilen)
        {
            ekmek.RemoveAt(secilen);
        }
    }
}
