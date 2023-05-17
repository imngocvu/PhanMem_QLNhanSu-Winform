using System;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HuynhNgocVu_QLNhanSU_TKTM
{
    public class Cl_NhanVien:ConnectData
    {
        public string MaNV, TenNV, MaPB, NS, DC, SDT;
        public string manv { get { return MaNV; } set { MaNV = value; } }
        public string tennv { get { return TenNV; } set { TenNV = value; } }
        public string mapb { get { return MaPB; } set { MaPB = value; } }
        public string ns { get { return NS; } set { NS = value; } }
        public string dc { get { return DC; } set { DC = value; } }
        public string sdt { get { return SDT; } set { SDT = value; } }

        public Cl_NhanVien() { }

        public Cl_NhanVien(string maNV, string tenNV, string maPB, string nS, string dC, string sDT)
        {
            MaNV = maNV;
            TenNV = tenNV;
            MaPB = maPB;
            NS = nS;
            DC = dC;
            SDT = sDT;
            this.manv = manv;
            this.tennv = tennv;
            this.mapb = mapb;
            this.ns = ns;
            this.dc = dc;
            this.sdt = sdt;
        }

        public void Insert_NhanVien()
        {
            string CN = "insert into NhanVien values('" + MaNV + "',N'" + TenNV + "','" + MaPB + "','" + NS + "','" + DC + "',N'" + SDT + "')";
            Comm = new SqlCommand(CN, Conn);
            Comm.ExecuteNonQuery();
        }

        public void Update_NhanVien()
        {
            string CN = "update NhanVien set TenNhanVien=N'" + TenNV + "',MaPhongBan='" + MaPB + "',NgaySinh='" + NS + "'  where MaNhanVien='" + MaNV + "'";
            Comm = new SqlCommand(CN, Conn);
            Comm.ExecuteNonQuery();
        }

        public void Delete_NhanVien()
        {
            string CN = "delete NhanVien where MaNhanVien='" + MaNV + "'";
            Comm = new SqlCommand(CN, Conn);
            Comm.ExecuteNonQuery();
        }
    }
}
