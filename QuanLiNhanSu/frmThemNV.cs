using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhanSu
{
    public partial class frmThemNV : Form
    {
        public frmThemNV()
        {
            InitializeComponent();
        }
        public void load()
        {
            dgvThemNV.DataSource = ConnectDatabase.getAllNhanVien();
        }


        private void btnThemNV_Click(object sender, EventArgs e)
        {
            NhanVien temp = new NhanVien(txtMaNV.Text, txtTenNV.Text, txtBangCap.Text, txtGT.Text, dateNS.Value, txtDC.Text, txtMaPB.Text, txtCMT.Text, txtSDT.Text, txtDT.Text, txtTG.Text);
            ConnectDatabase.ThemNhanVien(temp);
           dgvThemNV.DataSource = ConnectDatabase.getAllNhanVien();
           

        }

        

        private void dgvThemNV_SelectionChanged(object sender, EventArgs e)
        {
            
            DataGridView table = sender as DataGridView;
            foreach (DataGridViewRow row in table.SelectedRows)
            {
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTenNV.Text = row.Cells[1].Value.ToString();
                txtBangCap.Text = row.Cells[2].Value.ToString();
                txtGT.Text = row.Cells[3].Value.ToString();
                dateNS.Value = row.Cells[4].Value == null ? DateTime.Now : (DateTime)row.Cells[4].Value;
                txtDC.Text = row.Cells[5].Value.ToString();
                txtMaPB.Text = row.Cells[6].Value.ToString();
                txtCMT.Text = row.Cells[7].Value.ToString();
                txtSDT.Text = row.Cells[8].Value.ToString();
                txtTG.Text = row.Cells[9].Value.ToString();
                txtDT.Text = row.Cells[10].Value.ToString();

            }
        }

        private void dgvThemNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            dgvThemNV.DataSource = ConnectDatabase.getAllNhanVien();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            
            dgvThemNV.DataSource = ConnectDatabase.getAllNhanVien();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmThemNV_Load(object sender, EventArgs e)
        {
            this.dgvThemNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void labelX6_Click(object sender, EventArgs e)
        {

        }
    }
}
