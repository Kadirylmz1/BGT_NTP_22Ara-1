using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace BGT_NTP_22Ara_1
{
    public partial class MusteriEkle : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            BasePath = "https://bgteticaret-default-rtdb.firebaseio.com/",
            AuthSecret = "1Pt4oDtxddCqEpVV3UlJxg0jSeOF3EstlnDpN1Nf"
        };

        IFirebaseClient client;

        public MusteriEkle()
        {
            InitializeComponent();
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteri musteri1= new Musteri();
            musteri1.ID = Convert.ToInt32(textBox1.Text);
            musteri1.Ad = textBox2.Text;
            musteri1.Soyad = textBox3.Text;
            musteri1.Telefon=textBox4.Text;
            musteri1.Adres = richTextBox1.Text;
            musteri1.Kayit=Environment.MachineName;
            client.Set("Musteriler/"+musteri1.ID+"/", musteri1);
        }
    }
}
