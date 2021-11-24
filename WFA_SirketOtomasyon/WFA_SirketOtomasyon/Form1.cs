using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_SirketOtomasyon.Classes;

namespace WFA_SirketOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Personel personel = new Personel()
            {
                Id = 1,
                Ad = "Fatih",
                Soyad = "Günalp",
                Adres = "Kadıköy"
            };

            InsanKaynaklari ik = new InsanKaynaklari();
            //string result=ik.IseAl(personel);
            //MessageBox.Show(result);
            //MessageBox.Show(ik.IstenCikar(personel));
            string aciklama = "personel adayı ile görüşüldü. çok yüksek ücret beklentisi bulunmaktadır!";
           string result= ik.Mulakat(personel, aciklama);
            MessageBox.Show(result);
        }
    }
}
