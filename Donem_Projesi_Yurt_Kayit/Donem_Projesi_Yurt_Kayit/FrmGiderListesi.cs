﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donem_Projesi_Yurt_Kayit
{
    public partial class FrmGiderListesi : Form
    {
        public FrmGiderListesi()
        {
            InitializeComponent();
        }

        private void FrmGiderListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurt_KayitDataSet10.Giderler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.giderlerTableAdapter.Fill(this.yurt_KayitDataSet10.Giderler);

        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            FrmGiderGüncelle frg = new FrmGiderGüncelle();
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            frg.elektirik = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frg.dogalgaz = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frg.internet = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frg.gıda = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frg.diger= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frg.Show();


        }
    }
}
