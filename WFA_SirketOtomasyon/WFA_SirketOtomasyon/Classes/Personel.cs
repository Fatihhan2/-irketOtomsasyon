using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_SirketOtomasyon.Enums;

namespace WFA_SirketOtomasyon.Classes
{
    public class Personel:BaseClass
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tckn { get; set; }
        public string TelefonNo { get; set; }
        public string Adres { get; set; }
        public Departman Departman { get; set; }
        public AppUser User { get; set; }

    }
}
