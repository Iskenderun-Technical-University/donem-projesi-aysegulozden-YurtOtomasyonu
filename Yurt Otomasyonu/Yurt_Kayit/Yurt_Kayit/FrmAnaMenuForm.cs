using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yurt_Kayit
{
    public partial class FrmAnaMenuForm : Form
    {
        public FrmAnaMenuForm()
        {
            InitializeComponent();
        }

        private void FrmAnaMenuForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yürtKayitDataSet1.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter.Fill(this.yürtKayitDataSet1.Ogrenci);

        }
    }
}
