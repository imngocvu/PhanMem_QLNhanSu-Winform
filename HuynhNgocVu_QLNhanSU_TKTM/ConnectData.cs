using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HuynhNgocVu_QLNhanSU_TKTM
{
    public class ConnectData
    {
        public SqlConnection Conn = new SqlConnection();
        public SqlCommand Comm = new SqlCommand();

        public void Conect_QLNhanSu()
        {
            Conn = new SqlConnection("Data Source=HUYNHNGOCVU;Initial Catalog=QLNhanSu;Integrated Security=True");
            Conn.Open();
        }

        public DataTable LayDL(string CauLenhTruyVan)
        {
            DataTable DT_Ta = new DataTable();
            Comm = new SqlCommand(CauLenhTruyVan, Conn);
            SqlDataAdapter DT_Ap = new SqlDataAdapter(Comm);
            DT_Ap.Fill(DT_Ta);
            return DT_Ta;
        }

        public void CapNhatDL(string CauLenhCapNhat)
        {
            Comm = new SqlCommand(CauLenhCapNhat, Conn);
            Comm.ExecuteNonQuery();
        }
    }
}
