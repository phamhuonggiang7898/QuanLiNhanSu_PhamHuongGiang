using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLiNhanSu
{
    public partial class frmThemPB : Form
    {
        public frmThemPB()
        {
            InitializeComponent();
            txtTenTp.ReadOnly = true;
        }
        ConnectDatabase db = new ConnectDatabase();
       
        
        public void load()
        {

            dgvThemPB.DataSource = ConnectDatabase.getAllPhongBan();
        }




        private void btnThemPB_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (!db.KiemTra(txtMaPB.Text, "select MaPB from PhongBan"))
            //    {
            //        PhongBan temp = new PhongBan(txtMaPB.Text, txtTenPB.Text, txtDiaChi.Text, txtmaTP.Text, txtTenTp.Text);

            //        ConnectDatabase.ThemPhongBan(temp);
            //        load();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Mã phòng này đã tòn tại bạn có thể thử mã phòng khác", "Trùng mã phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Dữ liệu đầu vào không đúng");
            //}
            PhongBan temp = new PhongBan(txtMaPB.Text, txtTenPB.Text, txtDiaChi.Text, txtmaTP.Text, txtTenTp.Text);

            ConnectDatabase.ThemPhongBan(temp);
            load();
        }

 
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
         
            dgvThemPB.DataSource = ConnectDatabase.getAllPhongBan();
        }

        private void frmThemPB_Load(object sender, EventArgs e)
        {
            dgvThemPB.DataSource = ConnectDatabase.getAllPhongBan();

        }

        private void txtmaTP_TextChanged(object sender, EventArgs e)
        {
            txtTenTp.Text = ConnectDatabase.getTenTruongPhongTuMaTruongPhong(txtmaTP.Text);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            load();
            this.Close();
        }

        private void dgvThemPB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

