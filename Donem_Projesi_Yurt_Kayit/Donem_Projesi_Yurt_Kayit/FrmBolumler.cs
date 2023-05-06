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

        private void PcbSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("delete from Bolumler where BolumID=@b1", baglanti);
            komut2.Parameters.AddWithValue("@b1", TxtBolumID.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi gerçekleşti");
            this.bolumlerTableAdapter.Fill(this.yurt_KayitDataSet.Bolumler);
        }
        int secilen;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID, bolumad;

            secilen = dataGridView1.SelectedCells[0].RowIndex;
            ID = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            TxtBolumID.Text = ID;
            TxtBolumAd.Text = bolumad;




        }

        private void PcbGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update Bolumler Set BolumAd=@b1 where BolumID=@b2", baglanti);
                komut3.Parameters.AddWithValue("@b1", TxtBolumAd.Text);
                komut3.Parameters.AddWithValue("@b2", TxtBolumID.Text);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme gerçekleşti");
                this.bolumlerTableAdapter.Fill(this.yurt_KayitDataSet.Bolumler);
            }
            catch 
            {
                MessageBox.Show("Güncelleme gerçekleşmedi");

            }



        }
    }
}
