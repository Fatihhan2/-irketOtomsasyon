using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_SirketOtomasyon.Data;
using WFA_SirketOtomasyon.Interfaces;

namespace WFA_SirketOtomasyon.Classes
{
    public class InsanKaynaklari : IInsanKaynaklari
    {
        //Insan  kaynakları özellikleri

        //Insan kaynakları neler yapabilir?
        //Mülakat
        //İşe Alım
        //İşten Çıkarma
        public string IseAl(Personel personel)
        {
            try
            {
                AppUser user = new AppUser();
                user.KullaniciAdi = personel.Tckn;
                //todo: şifre random olarak 8 haneli tanımlanacak. içerisinde en az 1 adet özel karakter, en az 1 adet büyük harf ve en az 1 adet rakam bulunacak.
                user.Sifre = "1234";
                personel.User = user;
                personel.IsActive = true;
                PersonelData.personelListesi.Add(personel);
                return $"{personel.Ad} {personel.Soyad} işe alındı!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string IstenCikar(Personel personel)
        {
            foreach (Personel p in PersonelData.personelListesi)
            {

                if (p.Id == personel.Id)
                {
                    p.IsActive = false;
                    
                }
                
            }
            return "Personel İşten ayrıldı!";
        }

        public string Mulakat(Personel personel, string aciklama)
        {
            MulakatData mulakat = new MulakatData();
            mulakat.Personel = personel;
            mulakat.Aciklama = aciklama;

            MulakatData.MulakatListesi.Add(mulakat);
            return $"{personel.Ad} {personel.Soyad} mülakat yapıldı sonuç bekleniyor.";

        }
    }
}
