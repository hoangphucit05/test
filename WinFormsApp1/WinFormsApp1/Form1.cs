namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text;

        }

        private void textHo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = "";

        }

        private void btnHo_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text;

        }

        private void btnHoten_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text + "" +txtTen.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
