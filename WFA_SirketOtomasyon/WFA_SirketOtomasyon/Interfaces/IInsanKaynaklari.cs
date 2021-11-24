using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_SirketOtomasyon.Classes;

namespace WFA_SirketOtomasyon.Interfaces
{
    public interface IInsanKaynaklari
    {
        string IseAl(Personel personel);
        string IstenCikar(Personel personel);
        string Mulakat(Personel personel, string aciklama);
    }
}
