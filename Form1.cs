namespace CSharp_ThiThu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương trình tiện ích", "Thông tin");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string thongTin = "Họ và tên: Huỳnh Thanh Tú\nMSSV: 01234567\nNgày thi: 19/08/2024\nMôn thi: Lập trình C#";
            lblInfo.Text = thongTin;
        }

        private void đăngKýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DKMonHoc dk = new DKMonHoc();
            dk.MdiParent = this;
            dk.Show();
        }
    }
}
 