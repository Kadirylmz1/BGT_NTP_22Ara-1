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
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            BasePath = "https://bgteticaret-default-rtdb.firebaseio.com/",
            AuthSecret = "1Pt4oDtxddCqEpVV3UlJxg0jSeOF3EstlnDpN1Nf"
        };

        IFirebaseClient client;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if(client != null ) {
                MessageBox.Show("Bağlantı Kuruldu");
            }
            string isim = Environment.MachineName;
            string tarih = DateTime.Now.ToString();
            string kayit = isim + "-___" + tarih;
            client.Set("/giris",kayit);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriEkle form2 =new MusteriEkle();
            form2.ShowDialog();
        }

    }
}
