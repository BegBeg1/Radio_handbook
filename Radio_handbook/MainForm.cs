using Radio_handbook.Models;

namespace Radio_handbook
{
    public partial class MainForm : Form
    {
        private Handbook handbook = new Handbook();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void seachBotton_Click(object sender, EventArgs e)
        {
            List<Resistor> result = handbook.Search(nameBox.Text, rBox.Text);
            resistorBindingSource.DataSource = result;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
