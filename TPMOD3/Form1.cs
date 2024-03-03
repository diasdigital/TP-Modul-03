namespace TPMOD3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Tombol_Click(object sender, EventArgs e)
        {
            String nama = boxNama.Text;
            Keluaran.Text = "Halo " + nama;
        }
    }
}
