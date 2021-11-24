using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_SirketOtomasyon.Classes;

namespace WFA_SirketOtomasyon.Data
{
    public class MulakatData:BaseClass
    {
        public Personel Personel { get; set; }
        public string Aciklama { get; set; }

        public static List<MulakatData> MulakatListesi = new List<MulakatData>(); 
    }
}
