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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SJJ7N21\SQLEXPRESS;Initial Catalog=Yurt_Kayit;Integrated Security=True");

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurt_KayitDataSet.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurt_KayitDataSet.Bolumler);

        }

        private void PcbEkle_Click(object sender, EventArgs e)
        {
            

                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("insert into Bolumler (BolumAd) values(@b1)", baglanti);
                komut1.Parameters.AddWithValue("@b1", TxtBolumAd.Text);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Bölüm eklendi");
            this.bolumlerTableAdapter.Fill(this.yurt_KayitDataSet.Bolumler);



        }
    }
}
