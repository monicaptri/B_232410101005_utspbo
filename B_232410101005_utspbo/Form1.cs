namespace B_232410101005_utspbo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HalamanTugas halamanTugas = new HalamanTugas();
            this.Hide();
            halamanTugas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HalamanPendaftaranPengguna halamanpendaftaranpengguna = new HalamanPendaftaranPengguna();
            this.Hide();
            halamanpendaftaranpengguna.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HalamanAdmin halamanAdmin = new HalamanAdmin();
            this.Hide();
            halamanAdmin.Show();
        }
    }
}
