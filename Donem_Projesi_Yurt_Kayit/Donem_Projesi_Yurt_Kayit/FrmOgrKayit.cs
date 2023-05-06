using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Donem_Projesi_Yurt_Kayit
{
    public partial class OgrKayit : Form
    {
        public OgrKayit()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        

        private void OgrKayit_Load(object sender, EventArgs e)
        {
            

            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler",bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                CmbBolum.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();

            
            SqlCommand komut2 = new SqlCommand("Select OdaNo From Odalar  where [Oda Kapasitesi] != OdaAktif",bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while(oku2.Read())
            {
                CmbOdalar.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            
            SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci (OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrBolum,OgrDogum,OgrOdaNo,OgrMail,VeliAd,VeliSoyad,VeliTelefon,VeliAdres) values (@o1,@o2,@o3,@o4,@o5,@o6,@o7,@o8,@v1,@v2,@v3,@v4)",bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@o1",TxtOgAd.Text);
            komutkaydet.Parameters.AddWithValue("@o2", txtOgrSoyad.Text);
            komutkaydet.Parameters.AddWithValue("@o3", MskTC.Text);
            komutkaydet.Parameters.AddWithValue("@o4", MskOgrTelefon.Text);
            komutkaydet.Parameters.AddWithValue("@o5", CmbBolum.Text);
            komutkaydet.Parameters.AddWithValue("@o6", MskDogumTarihi.Text);
            komutkaydet.Parameters.AddWithValue("@o7", CmbOdalar.Text);
            komutkaydet.Parameters.AddWithValue("@o8", TxtMail.Text);

            komutkaydet.Parameters.AddWithValue("@v1", TxtVeliAd.Text);
            komutkaydet.Parameters.AddWithValue("@v2", TxtVeliSoyad.Text);
            komutkaydet.Parameters.AddWithValue("@v3", MskVeliTelefon.Text);
            komutkaydet.Parameters.AddWithValue("@v4", richTextBox1.Text);

            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt işlemi aşarılı olmuştur ");
        }
    }
}

//Data Source=DESKTOP-SJJ7N21\SQLEXPRESS;Initial Catalog=Yurt_Kayit;Integrated Security=True