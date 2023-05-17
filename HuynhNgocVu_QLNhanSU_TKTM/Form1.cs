using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HuynhNgocVu_QLNhanSU_TKTM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ConnectData CN = new ConnectData();
        private Cl_NhanVien NV = new Cl_NhanVien();
        private DataTable tbl_All = new DataTable();
        private void DO_DL_VaoGV()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < tbl_All.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < tbl_All.Columns.Count; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = tbl_All.Rows[i][j].ToString();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CN.Conect_QLNhanSu();
            tbl_All = CN.LayDL("select * from NhanVien");
            DO_DL_VaoGV();
            tbl_All = CN.LayDL("select * from PhongBan");
            cbMaPhongBan.Items.Clear();
            for (int i = 0; i < tbl_All.Rows.Count; i++)
            {
                cbMaPhongBan.Items.Add(tbl_All.Rows[i][0].ToString());
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            NV = new Cl_NhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, cbMaPhongBan.Text, mktxtNgaySinh.Text, txtDiaChi.Text, txtSoDienThoai.Text);
            NV.Conect_QLNhanSu();
            MessageBox.Show("Thêm Thành Công");
            NV.Insert_NhanVien();
            Form1_Load(sender, e);
            NV.Conn.Close();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NV = new Cl_NhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, cbMaPhongBan.Text, mktxtNgaySinh.Text, txtDiaChi.Text, txtSoDienThoai.Text);
            NV.Conect_QLNhanSu();
            NV.Update_NhanVien();
            MessageBox.Show("Sửa Thành Công");
            Form1_Load(sender, e);
            NV.Conn.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NV = new Cl_NhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, cbMaPhongBan.Text, mktxtNgaySinh.Text, txtDiaChi.Text, txtSoDienThoai.Text);
            NV.Conect_QLNhanSu();
            MessageBox.Show("Xoá Thành Công");
            NV.Delete_NhanVien();
            Form1_Load(sender, e);
            NV.Conn.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
            int dong_ht = dataGridView1.CurrentRow.Index;
            if (dong_ht > dataGridView1.Rows.Count - 2)
                return;
            else
            {
                txtMaNhanVien.Text = dataGridView1.Rows[dong_ht].Cells[0].Value.ToString();
                txtTenNhanVien.Text = dataGridView1.Rows[dong_ht].Cells[1].Value.ToString();
                cbMaPhongBan.Text = dataGridView1.Rows[dong_ht].Cells[2].Value.ToString();
                mktxtNgaySinh.Text = dataGridView1.Rows[dong_ht].Cells[3].Value.ToString();
                txtDiaChi.Text = dataGridView1.Rows[dong_ht].Cells[4].Value.ToString();
                txtSoDienThoai.Text = dataGridView1.Rows[dong_ht].Cells[5].Value.ToString();
            }
        }
    }
}
