using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Yurt_Kayit
{
     public class FrmSqlBaglanti
    {
        public SqlConnection connection()
        {

            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-SJJ7N21\\SQLEXPRESS;Initial Catalog=YürtKayit;Integrated Security=True");
            connect.Open();
            return connect;
        }

    }
}
