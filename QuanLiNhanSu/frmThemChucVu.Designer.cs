namespace QuanLiNhanSu
{
    partial class frmThemCV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTCV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMCV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnNhaplai = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvThemCV = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.btnquaylai = new DevComponents.DotNetBar.ButtonX();
            this.btnThemCV = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemCV)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(332, 12);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(218, 23);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "THÊM CHỨC VỤ MỚI";
            this.labelX3.Click += new System.EventHandler(this.labelX3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.dgvThemCV);
            this.groupBox2.Location = new System.Drawing.Point(37, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(808, 438);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnquaylai);
            this.groupBox1.Controls.Add(this.btnThemCV);
            this.groupBox1.Controls.Add(this.txtTCV);
            this.groupBox1.Controls.Add(this.txtMCV);
            this.groupBox1.Controls.Add(this.btnNhaplai);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Location = new System.Drawing.Point(13, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 374);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTCV
            // 
            // 
            // 
            // 
            this.txtTCV.Border.Class = "TextBoxBorder";
            this.txtTCV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTCV.Location = new System.Drawing.Point(109, 86);
            this.txtTCV.Name = "txtTCV";
            this.txtTCV.Size = new System.Drawing.Size(119, 20);
            this.txtTCV.TabIndex = 23;
            this.txtTCV.TextChanged += new System.EventHandler(this.txtTCV_TextChanged);
            // 
            // txtMCV
            // 
            // 
            // 
            // 
            this.txtMCV.Border.Class = "TextBoxBorder";
            this.txtMCV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMCV.Location = new System.Drawing.Point(109, 42);
            this.txtMCV.Name = "txtMCV";
            this.txtMCV.Size = new System.Drawing.Size(119, 20);
            this.txtMCV.TabIndex = 2;
            this.txtMCV.TextChanged += new System.EventHandler(this.txtMCV_TextChanged);
            // 
            // btnNhaplai
            // 
            this.btnNhaplai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNhaplai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNhaplai.Location = new System.Drawing.Point(153, 139);
            this.btnNhaplai.Name = "btnNhaplai";
            this.btnNhaplai.Size = new System.Drawing.Size(75, 23);
            this.btnNhaplai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNhaplai.TabIndex = 22;
            this.btnNhaplai.Text = "Nhập lại";
            this.btnNhaplai.Click += new System.EventHandler(this.btnNhaplai_Click_1);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(19, 83);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Tên chức vụ";
            this.labelX2.Click += new System.EventHandler(this.labelX2_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(19, 42);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Mã chức vụ";
            this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // dgvThemCV
            // 
            this.dgvThemCV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThemCV.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThemCV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThemCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThemCV.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThemCV.EnableHeadersVisualStyles = false;
            this.dgvThemCV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvThemCV.Location = new System.Drawing.Point(295, 31);
            this.dgvThemCV.Name = "dgvThemCV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThemCV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThemCV.Size = new System.Drawing.Size(486, 374);
            this.dgvThemCV.TabIndex = 6;
            this.dgvThemCV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThemCV_CellContentClick);
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Image = global::QuanLiNhanSu.Properties.Resources.cancel;
            this.btnHuy.Location = new System.Drawing.Point(144, 183);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(84, 33);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 36;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnquaylai
            // 
            this.btnquaylai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnquaylai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnquaylai.Image = global::QuanLiNhanSu.Properties.Resources.backward2;
            this.btnquaylai.Location = new System.Drawing.Point(138, 326);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(84, 25);
            this.btnquaylai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnquaylai.TabIndex = 33;
            this.btnquaylai.Text = "Trở lại";
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // btnThemCV
            // 
            this.btnThemCV.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemCV.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemCV.Image = global::QuanLiNhanSu.Properties.Resources.user_male_add23;
            this.btnThemCV.Location = new System.Drawing.Point(59, 178);
            this.btnThemCV.Name = "btnThemCV";
            this.btnThemCV.Size = new System.Drawing.Size(75, 38);
            this.btnThemCV.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemCV.TabIndex = 24;
            this.btnThemCV.Text = "Thêm";
            this.btnThemCV.Click += new System.EventHandler(this.btnThemCV_Click_2);
            // 
            // frmThemCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(891, 503);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelX3);
            this.Name = "frmThemCV";
            this.Text = "frmThemCV";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemCV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnThemCV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTCV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMCV;
        private DevComponents.DotNetBar.ButtonX btnNhaplai;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvThemCV;
        private DevComponents.DotNetBar.ButtonX btnquaylai;
        private DevComponents.DotNetBar.ButtonX btnHuy;
    }
}