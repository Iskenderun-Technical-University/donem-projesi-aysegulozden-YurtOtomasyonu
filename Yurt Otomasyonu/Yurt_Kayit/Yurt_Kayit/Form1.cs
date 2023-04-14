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

namespace Yurt_Kayit
{
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SJJ7N21\\SQLEXPRESS;Initial Catalog=YürtKayit;Integrated Security=True");

        private void FrmOgrKayit_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                CmbBolum.Items.Add(oku[0].ToString());
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Odano From Odalar where OdaKapasite != OdaAktif", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while(oku2.Read())
            {
                CmbOdaNo.Items.Add(oku2[0].ToString());
            }
            baglanti.Close();


        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            

                baglanti.Open();
                SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci (OgrAd,OgrSoyad,OgrTc,OgrTelefon,OgrDogum,OgrBölüm,OgrMail,OgrOdaNo,OgrVeliAd,OgrVeliSoyad,OgrVeliTelefon,OgrVeliAdres) values(@o1,@o2,@o3,@o4,@o5,@o6,@o7,@o8,@v9,@v10,@v11,@v12)", baglanti);

                komutkaydet.Parameters.AddWithValue("@o1", TxtOgrAd.Text);
                komutkaydet.Parameters.AddWithValue("@o2", TxtOgrSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@o3", MskTC.Text);
                komutkaydet.Parameters.AddWithValue("@o4", MskTelefonOgr.Text);
                komutkaydet.Parameters.AddWithValue("@o5", MskDogumTarihi.Text);
                komutkaydet.Parameters.AddWithValue("@o6", CmbBolum.Text);
                komutkaydet.Parameters.AddWithValue("@o7", TxtOgrMail.Text);
                komutkaydet.Parameters.AddWithValue("@o8", CmbOdaNo.Text);
                komutkaydet.Parameters.AddWithValue("@v9", TxtVeliAd.Text);
                komutkaydet.Parameters.AddWithValue("@v10", TxtVeliSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@v11", MskVeliTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@v12", richTextBox1.Text);

                komutkaydet.ExecuteNonQuery();
                baglanti.Close();
               

        }
    }
}
//Data Source=DESKTOP-SJJ7N21\SQLEXPRESS;Initial Catalog=YürtKayit;Integrated Security=True
