using System;
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
    public partial class FrmAdminGiriş : Form
    {
        public FrmAdminGiriş()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if(TxtKullanıcıAdı.Text=="admin33" && TxtSifre.Text=="123456")
            {
                FrmAnaMenu fr = new FrmAnaMenu();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
            }
        }
    }
}
