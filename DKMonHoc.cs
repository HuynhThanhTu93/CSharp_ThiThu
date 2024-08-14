using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_ThiThu
{
    public partial class DKMonHoc : Form
    {
        public DKMonHoc()
        {
            InitializeComponent();
        }

        private void DKMonHoc_Load(object sender, EventArgs e)
        {
            cckMonHoc.Items.Add("LT WIN");
            cckMonHoc.Items.Add("LT Internet");
            cckMonHoc.Items.Add("Mạng máy tính");
            cckMonHoc.Items.Add("UML");

            cbxNienKhoa.Items.Add("2024");
            cbxNienKhoa.Items.Add("2025");
            cbxNienKhoa.Items.Add("2026");
            cbxNienKhoa.Items.Add("2027");
            cbxNienKhoa.Items.Add("2028");
            cbxNienKhoa.Items.Add("2029");
            cbxNienKhoa.Items.Add("2030");
            cbxNienKhoa.SelectedIndex = 0;

            cbxLop.Items.Add("Ứng dụng phần mềm 1");
            cbxLop.Items.Add("Ứng dụng phần mềm 2");
            cbxLop.Items.Add("Ứng dụng phần mềm 3");
            cbxLop.Items.Add("Thiết kế đồ họa 1");
            cbxLop.Items.Add("Thiết kế đồ họa 2");
            cbxLop.Items.Add("Ứng dụng phần mềm 1");
            cbxLop.Items.Add("Ứng dụng phần mềm 2");
            cbxLop.SelectedIndex = 0;
            rdbI.Checked = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtHOTEN.Text = "";
            txtMSSV.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            string Info;
            Info = "Mã số sinh viên: " + txtMSSV.Text;
            Info += "\nHọ và tên: " + txtHOTEN.Text;
            Info += "\nNiên khóa: " + cbxNienKhoa.SelectedItem;
            Info += "\nLớp: " + cbxLop.SelectedItem;

            string hocky = "";
            if (rdbI.Checked)
                hocky = rdbI.Text;
            else if (rdbII.Checked) hocky = rdbII.Text;
            else if (rdbIII.Checked) hocky = rdbIII.Text;
            else if (rdbIV.Checked) hocky = rdbIV.Text;
        }
    }
}
