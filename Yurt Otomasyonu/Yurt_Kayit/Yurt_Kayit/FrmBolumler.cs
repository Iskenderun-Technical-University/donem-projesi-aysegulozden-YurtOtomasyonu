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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SJJ7N21\\SQLEXPRESS;Initial Catalog=YürtKayit;Integrated Security=True");

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yürtKayitDataSet.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yürtKayitDataSet.Bolumler);

        }

        private void PcbKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("insert into Bolumler(BolumAd) values (@b1)", baglanti);
                komut1.Parameters.AddWithValue("@b1", TxtBolumAd.Text);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ekleme İşlemi Başarılı Şekilde Gerçekleşti");
                this.bolumlerTableAdapter.Fill(this.yürtKayitDataSet.Bolumler);

            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu Lütfen Yeniden Deneyin");
                    
            }
        }

        private void PcbSil_Click(object sender, EventArgs e)
        {
            
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("delete from Bolumler where Bolumid=@b1", baglanti);
                komut2.Parameters.AddWithValue("@b1", TxtBolumİD);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Yapılmıştır");

        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();


            TxtBolumİD.Text= id;
            TxtBolumAd.Text=bolumad;



        }

        private void PcbGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("update Bolumler set Bolumad=@b1 where Bolumid=@b2 ", baglanti);
            komut3.Parameters.AddWithValue("@b1", TxtBolumAd.Text);
            komut3.Parameters.AddWithValue("b2", TxtBolumİD.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
