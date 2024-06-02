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
using System.Windows.Forms.Design;

namespace Radio_handbook.Forms
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        Handbook handbook = new Handbook();

        public MainForm()
        {
            InitializeComponent();
            searchButton_Click(null, null);

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете закрити програму?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
        public RadioComponent? SelectedComponent
        {
            get
            {
                var selectedRows = dataGridView1.SelectedRows;
                if (selectedRows == null || selectedRows.Count == 0)
                {
                    return null;
                }
                return selectedRows[0].DataBoundItem as RadioComponent;
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Ви впевнені, що хочете видалити елемент {SelectedComponent.Name}?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                handbook.RadioComponents.RemoveAt(handbook.RadioComponents.IndexOf(SelectedComponent));
                searchButton_Click(null, null);
                if (SelectedComponent == null)
                {
                    deleteButton.Enabled = false;
                    changeButton.Enabled = false;
                }
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            var result = handbook.Search(idTextBox.Text.Trim(), nameTextBox.Text.Trim(), typeTextBox.Text.Trim(),
                                            resistanceTextBox.Text.Trim(), capacitanceTextBox.Text.Trim(),
                                            inductanceTextBox.Text.Trim(), descriptionTextBox.Text.Trim());
            dataGridView1.DataSource = result;
        }

        private void aboutToolStripMenuItem_Click(Object sender, EventArgs e)
        {

        }
        private void changeButton_Click(Object sender, EventArgs e)
        {
            var componentEditForm = new ComponentEditForm(SelectedComponent);
            if (componentEditForm.ShowDialog() == DialogResult.OK)
            {
                searchButton_Click(null, null);
            }
        }
        private void addButton_Click(Object sender, EventArgs e)
        {
            var addComponentForm = new AddComponentForm(handbook.RadioComponents);
            if (addComponentForm.ShowDialog() == DialogResult.OK)
            {
                searchButton_Click(null, null);
            }
        }
    }
}
