using Radio_handbook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_handbook.Forms
{
    public partial class MainForm : Form
    {
        Handbook handbook = new Handbook();
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете закрити програму?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }   
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            var result = handbook.Search(idTextBox.Text, nameTextBox.Text, typeTextBox.Text, 
                                            resistanceTextBox.Text, capacitanceTextBox.Text, 
                                            inductanceTextBox.Text, descriptionTextBox.Text);
            listBox.Items.Clear();
            foreach (var item in result)
            {
                listBox.Items.Add(item.Name);
            }

        }
    }
}
